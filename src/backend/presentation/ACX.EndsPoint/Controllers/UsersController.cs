using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Update;
using ACX.EndsPoint.ActionFilters;
using ACX.ServiceContract.Common;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace ACX.EndsPoint.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/users")]
    [ApiController]
    //[Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public UsersController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET
        [HttpGet]
        [HttpHead]
        //[Authorize(Roles ="Manager")]
        public async Task<ActionResult> GetAllUsers([FromQuery] UserRequestParameter requestParameter)
        {
            var result = await _serviceManager.UserService.GetAllUsers(requestParameter);
            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(result.MetaData));      
            return Ok(result.Users);
        }

        // GET id
        [HttpGet("{id}", Name = "GetUserById")]
        public async Task<ActionResult> GetUserById(string id)
        {
            var result = await _serviceManager.UserService.GetUserById(id);
            return Ok(result);
        }
        // GET email
        [HttpGet("email/{email}", Name = "GetUserByEmail")]
        public async Task<ActionResult> GetUserByEmail(string email)
        {
            var result = await _serviceManager.UserService.GetUserByEmail(email);
            return Ok(result);
        }

        // POST 
        /*[HttpPost]
        //[ServiceFilter(typeof(ValidationActionFilter))]
        public async Task<ActionResult> Post([FromBody] UserCreationDto userCreationDto)
        {
            var result = await _serviceManager.UserService.CreateUser(userCreationDto);
            return CreatedAtAction(nameof(GetUserById), new {id=result.Id}, result);
        }*/

        // PUT 
        [HttpPut()]
        public async Task<ActionResult> Put([FromBody] UserUpdateDto userUpdateDto)
        {
            await _serviceManager.UserService.UpdateUser(userUpdateDto);
            return NoContent();
        }

        // DELETE 
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeleteUser(string id)
        {
            await _serviceManager.UserService.DeleteUser(id);
            return NoContent();
        }
        [HttpOptions]
        public IActionResult Options()
        {
            Response.Headers.Add("Allow", "GET, OPTIONS, POST, PUT");
            return Ok();
        }
    }
}
