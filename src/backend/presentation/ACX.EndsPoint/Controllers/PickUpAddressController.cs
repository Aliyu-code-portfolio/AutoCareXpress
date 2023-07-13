using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Update;
using ACX.EndsPoint.ActionFilters;
using ACX.ServiceContract.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.EndsPoint.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/pickup")]
    [ApiController]
    public class PickUpAddressController: ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public PickUpAddressController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        

        // GET id
        [HttpGet("{id}", Name = "GetPickUpById")]
        [HttpHead]
        public async Task<ActionResult> GetPickUpById(string id)
        {
            var result = await _serviceManager.PickUpAddressService.GetUserPickUpAddress(id, false);
            return Ok(result);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationActionFilter))]
        public async Task<ActionResult> AddPickUpAddress(PickUpAddressCreationDto pickUpAddressCreationDto)
        {
            var result = await _serviceManager.PickUpAddressService.CreateUserPickUpAddress(pickUpAddressCreationDto);
            return CreatedAtAction(nameof(GetPickUpById), new { id = result.userId },result);
        }

        // PUT 
        [HttpPut()]
        public async Task<ActionResult> Put([FromBody] PickUpAddressUpdateDto pickUpAddressUpdateDto)
        {
            await _serviceManager.PickUpAddressService.UpdatePickUpAddress(pickUpAddressUpdateDto);
            return NoContent();
        }

        // DELETE 
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePickUpAddress(string id)
        {
            await _serviceManager.PickUpAddressService.DeletePickUpAddress(id);
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
