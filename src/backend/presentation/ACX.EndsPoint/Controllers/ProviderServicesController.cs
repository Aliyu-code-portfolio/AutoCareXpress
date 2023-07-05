﻿using ACX.Application.DTOs.Creation;
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
    [ApiVersion("1.0")]
    [Route("api/services")]
    [ApiController]
    public class ProviderServicesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public ProviderServicesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET
        [HttpGet]
        [HttpHead]
        public async Task<ActionResult> GetAllProvidersService()
        {
            var result = await _serviceManager.ProviderServiceService.GetAllProviderServices(trackChanges: false);
            return Ok(result);
        }

        // GET id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _serviceManager.ProviderServiceService.GetProviderServiceById(id,false);
            return Ok(result);
        }

        // POST 
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProviderServiceCreationDto providerServiceCreationDto)
        {
            var result = await _serviceManager.ProviderServiceService.CreateProviderService(providerServiceCreationDto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id });
        }

        // PUT 
        //[HttpPut()]
        //public ActionResult Put([FromBody] ProviderServiceUpdateDto providerServiceUpdateDto)
        //{
        //    _serviceManager.ProviderServiceService.  (userUpdateDto);
        //    return NoContent();
        //}

        // DELETE 
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeleteUser(Guid id)
        {
            await _serviceManager.UserService.DeleteUser(id);
            return NoContent();
        }
        [HttpOptions]
        public IActionResult Options()
        {
            Response.Headers.Add("Allow", "GET, OPTIONS, POST");
            return Ok();
        }
    }
}
