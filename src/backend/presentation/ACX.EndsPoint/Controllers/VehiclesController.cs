using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Update;
using ACX.ServiceContract.Common;
using Microsoft.AspNetCore.Mvc;

namespace ACX.EndsPoint.Controllers
{
    [Route("api/vehicles")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public VehiclesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET
        [HttpGet]
        public async Task<ActionResult> GetAllVehicles(bool trackChanges)
        {
            var result = await _serviceManager.VehicleService.GetAllVehicles(trackChanges);
            return Ok(result);
        }

        // GET
        [HttpGet]
        public async Task<ActionResult> GetAllUserVehicles(Guid userId, bool trackChanges)
        {
            var result = await _serviceManager.VehicleService.GetAllUserVehicles(userId, trackChanges);
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
            return CreatedAtAction(nameof(GetById), new {id=result.Id});
        }

        // PUT 
        [HttpPut()]
        public ActionResult Put([FromBody] VehicleUpdateDto vehicleUpdateDto)
        {
            _serviceManager.VehicleService.UpdateVehicle(vehicleUpdateDto);
            return NoContent();
        }

        // DELETE 
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteVehicle(int id)
        {
            _serviceManager.VehicleService.DeleteVehicle(id);
            return NoContent();
        }
    }
}
