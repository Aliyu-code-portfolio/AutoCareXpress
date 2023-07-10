using ACX.Application.DTOs.Creation;
using ACX.EndsPoint.ActionFilters;
using ACX.ServiceContract.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ACX.EndsPoint.Controllers
{
    //[ApiVersion("1.0")]
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController:ControllerBase
    {
        private readonly IServiceManager _service;
        public AuthenticationController(IServiceManager service) => _service = service;

        [HttpPost("register/admin")]
        [ServiceFilter(typeof(ValidationActionFilter))]
        [Authorize(Roles ="Manager")]
        public async Task<ActionResult> RegisterSpecialUser([FromBody] UserRegistrationDto userCreationDto)
        {
            var result = await _service.AuthenticationService.RegisterUser(userCreationDto);
            if(!result.Succeeded)
            {
                foreach(var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }
        [HttpPost("register")]
        [ServiceFilter(typeof(ValidationActionFilter))]
        public async Task<ActionResult> RegisterUser([FromBody] UserRegistrationDto userCreationDto)
        {
            foreach(var role in userCreationDto.Roles)
            {
                if (role.ToLower().Contains("manager") || role.ToLower().Contains("admin"))
                {
                    return StatusCode(401);
                }
            }
            var result = await _service.AuthenticationService.RegisterUser(userCreationDto);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }
        [HttpPost("login")]
        [ServiceFilter(typeof(ValidationActionFilter))]
        public async Task<ActionResult> LoginUser(UserForAuthenticationDto userForAuthenticationDto)
        {
            if (!await _service.AuthenticationService.ValidateUser(userForAuthenticationDto))
            {
                return Unauthorized();
            }
            var tokenDto = await _service.AuthenticationService
.CreateToken(populateExp: true);
            return Ok(tokenDto);

        }
    }
}
