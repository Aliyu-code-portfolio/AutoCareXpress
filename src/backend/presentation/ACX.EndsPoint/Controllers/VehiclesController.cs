using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Update;
using ACX.ServiceContract.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACX.EndsPoint.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/vehicles")]
    [ApiController]
    //[Authorize]
    public class VehiclesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public VehiclesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET
        [HttpGet]
        [HttpHead]
        //[Authorize]
        public async Task<ActionResult> GetAllVehicles()
        {
            var result = await _serviceManager.VehicleService.GetAllVehicles(false);
            return Ok(result);
        }

        // GET
        [HttpGet("user/{userId}")]
        public async Task<ActionResult> GetAllUserVehicles(string userId)
        {
            var result = await _serviceManager.VehicleService.GetAllUserVehicles(userId, false);
            return Ok(result);
        }

        // GET id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _serviceManager.VehicleService.GetVehicleById(id);
            return Ok(result);
        }

        // POST 
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] VehicleCreationDto vehicleCreationDto)
        {
            var result = await _serviceManager.VehicleService.CreateVehicle(vehicleCreationDto);
            return CreatedAtAction(nameof(GetById), new {id=result.Id},result);
        }

        // PUT 
        [HttpPut()]
        public async Task<ActionResult> Put([FromBody] VehicleUpdateDto vehicleUpdateDto)
        {
            await _serviceManager.VehicleService.UpdateVehicle(vehicleUpdateDto);
            return NoContent();
        }

        // DELETE 
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteVehicle(int id)
        {
            await _serviceManager.VehicleService.DeleteVehicle(id);
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
