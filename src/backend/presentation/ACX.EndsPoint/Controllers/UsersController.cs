using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Update;
using ACX.ServiceContract.Common;
using Microsoft.AspNetCore.Mvc;

namespace ACX.EndsPoint.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public UsersController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET
        [HttpGet]
        public async Task<ActionResult> GetAllUsers()
        {
            var result = await _serviceManager.UserService.GetAllUsers();
            return Ok(result);
        }

        // GET id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            var result = await _serviceManager.UserService.GetUserById(id);
            return Ok(result);
        }

        // POST 
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserCreationDto userCreationDto)
        {
            var result = await _serviceManager.UserService.CreateUser(userCreationDto);
            return CreatedAtAction(nameof(GetById), new {id=result.Id});
        }

        // PUT 
        [HttpPut()]
        public ActionResult Put([FromBody] UserUpdateDto userUpdateDto)
        {
            _serviceManager.UserService.UpdateUser(userUpdateDto);
            return NoContent();
        }

        // DELETE 
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeleteUser(Guid id)
        {
            _serviceManager.UserService.DeleteUser(id);
            return NoContent();
        }
    }
}
