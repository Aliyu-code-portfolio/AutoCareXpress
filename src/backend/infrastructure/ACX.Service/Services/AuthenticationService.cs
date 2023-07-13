using ACX.Application.Common;
using ACX.Application.DTOs.Creation;
using ACX.Application.Exceptions;
using ACX.Application.Exceptions.SubExceptions;
using ACX.Domain.Model;
using ACX.ServiceContract.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ACX.Service.Services
{
    internal sealed class AuthenticationService : IAuthenticationService
    {
        //private readonly ILoggerManager _logger;
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly ILoggerManager _logger;
        private readonly IConfiguration _configuration;
        private readonly IEmailSender _emailSender;

        private User? _user;

        public AuthenticationService(IRepositoryManager manager, IMapper mapper,ILoggerManager logger, UserManager<User> userManager,IEmailSender emailSender, IConfiguration configuration)
        {
            _repositoryManager = manager;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
            _emailSender = emailSender;
        }

        public async Task<TokenDto> CreateToken(bool populateExp)
        {
            if(!_user.EmailConfirmed)
            {
                throw new VerificationFailException("User has not verify email. Verify email.");
            }
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

            var refreshToken = GenerateRefreshToken();
            _user.RefreshToken = refreshToken;
            if (populateExp)
                _user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);
            await _userManager.UpdateAsync(_user);
            var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return new TokenDto(accessToken, refreshToken);

        }

        public async Task<TokenDto> RefreshToken(TokenDto tokenDto)
        {
            var principal = GetPrincipalFromExpiredToken(tokenDto.AccessToken);
            var user = await _userManager.FindByNameAsync(principal.Identity.Name);
            if (user == null || user.RefreshToken != tokenDto.RefreshToken ||
            user.RefreshTokenExpiryTime <= DateTime.Now)
                throw new RefreshTokenBadRequest();
            _user = user;
            return await CreateToken(populateExp: false);
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");

            var tokenOptions = new JwtSecurityToken(
                    issuer: jwtSettings["validIssuer"],
                    audience: jwtSettings["validAudience"],
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])),
                    signingCredentials:signingCredentials
                );
            return tokenOptions;
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,_user.Email)
            };
            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET"));
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret,SecurityAlgorithms.HmacSha256);
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET"))),
                ValidateLifetime = true,
                ValidIssuer = jwtSettings["validIssuer"],
                ValidAudience = jwtSettings["validAudience"]
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out
           securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null ||
           !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
            StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }
            return principal;
        }

        public async Task<IdentityResult> RegisterUser(UserRegistrationDto userRegistrationDto)
        {
            var user = _mapper.Map<User>(userRegistrationDto);
            user.UserName = user.Email;
            var result = await _userManager.CreateAsync(user,
            userRegistrationDto.Password);
            if (result.Succeeded)
                await _userManager.AddToRolesAsync(user, userRegistrationDto.Roles);
            await SendOTPEmail(user.Id, user.Email);
            return result;
        }

        public async Task<IdentityResult> RegisterProvider(ServiceProviderCreationDto serviceProviderCreationDto)
        {
            var user = _mapper.Map<User>(serviceProviderCreationDto);
            user.Email = serviceProviderCreationDto.CompanyEmail;
            user.UserName = user.Email;
            var result = await _userManager.CreateAsync(user,
            serviceProviderCreationDto.Password);
            if (result.Succeeded)
                await _userManager.AddToRolesAsync(user, serviceProviderCreationDto.Roles);
            var providerModel = _mapper.Map<ServiceProvider>(serviceProviderCreationDto);
            providerModel.Id=user.Id;
            _repositoryManager.ServiceProviderRepository.CreateServiceProvider(providerModel);
            await _repositoryManager.SaveChangesAsync();
            await SendOTPEmail(user.Id, user.Email);
            return result;
        }

        private async Task SendOTPEmail(string id, string email)
        {//Use outlook
            var code = new Random().Next(1234,9899);
            var body = $"Hi, Welcome to AutoCareXpress \nYour One Time Password (OTP) is {code}. " +
                $"Use this code to verify your Email Address on AutoCareXpress\nDo not share this message with anyone. " +
                $"This code is valid for 10 minutes ";
            await _emailSender.SendEmailAsync(email, "Verify your account AUTOCAREXPRESS", body);
            var user = await _repositoryManager.UserRepository.GetUserByIdAsync(id, false)
                ?? throw new UserNotFoundException(id);
            user.EmailVerifyCode = code;
            user.EmailTokenExpiryDate = DateTime.Now.AddMinutes(10);
            _repositoryManager.UserRepository.UpdateUser(user);
            await _repositoryManager.SaveChangesAsync();
        }

        public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuthenticationDto)
        {
            _user = await _userManager.FindByEmailAsync(userForAuthenticationDto.Email);
            var result = (_user != null && await _userManager.CheckPasswordAsync(_user,
           userForAuthenticationDto.Password));
            if (!result)
                _logger.LogWarn($"{nameof(ValidateUser)}: Authentication failed. Wrong user name or password.");
 return result;
        }

        public async Task SendVerifyCodeToEmail(string id)
        {
            var user = await _repositoryManager.UserRepository.GetUserByIdAsync(id, false)
                ?? throw new UserNotFoundException(id);
            if (user.EmailConfirmed)
            {
                throw new VerificationFailException("Email already verified");
            }
            await SendOTPEmail(id, user.Email);
        }

        public async Task VerifyEmail(string id, int payload)
        {
            var user = await _repositoryManager.UserRepository.GetUserByIdAsync(id, false)
                ?? throw new UserNotFoundException(id);
            if (user.EmailVerifyCode != payload)
            {
                throw new VerificationFailException($"Failed to verify, wrong code");
            }
            if (user.EmailTokenExpiryDate < DateTime.Now)
            {
                throw new VerificationFailException($"Failed to verify, expired code");
            }
            user.EmailTokenExpiryDate = DateTime.Now;
            user.EmailVerifyDate = DateTime.Now;
            user.EmailConfirmed = true;
            _repositoryManager.UserRepository.UpdateUser(user);
            await _repositoryManager.SaveChangesAsync();
        }
    }
}
