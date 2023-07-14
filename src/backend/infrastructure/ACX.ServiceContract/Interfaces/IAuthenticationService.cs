using ACX.Application.DTOs.Creation;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.ServiceContract.Interfaces
{
    public interface IAuthenticationService
    {
        Task<(IdentityResult result, string id)> RegisterProvider(ServiceProviderCreationDto userCreationDto);
        Task<(IdentityResult result, string id)> RegisterUser(UserRegistrationDto userCreationDto);
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuthenticationDto);
        Task<TokenDto> CreateToken(bool populateExp);
        Task<TokenDto> RefreshToken(TokenDto tokenDto);
        Task SendPasswordResetCode(string id);
        Task VerifyPasswordForgot(string id, int payload, string password);
        Task VerifyEmail(string id,int payload);
        Task SendVerifyCodeToEmail(string id);
    }
}
