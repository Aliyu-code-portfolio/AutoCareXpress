using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Update;
using ACX.ServiceContract.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.EndsPoint.Controllers
{
    public class PickUpAddressController: ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public PickUpAddressController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        

        // GET id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            var result = await _serviceManager.PickUpAddressService.GetUserPickUpAddress(id, false);
            return Ok(result);
        }

        

        // PUT 
        [HttpPut()]
        public ActionResult Put([FromBody] PickUpAddressUpdateDto pickUpAddressUpdateDto)
        {
            _serviceManager.PickUpAddressService.UpdatePickUpAddress(pickUpAddressUpdateDto);
            return NoContent();
        }

        // DELETE 
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeletePickUpAddress(Guid id)
        {
            _serviceManager.PickUpAddressService.DeletePickUpAddress(id);
            return NoContent();
        }
    }
}
