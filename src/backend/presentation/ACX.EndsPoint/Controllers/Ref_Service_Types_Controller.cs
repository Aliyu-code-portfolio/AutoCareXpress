﻿using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Update;
using ACX.ServiceContract.Common;
using Microsoft.AspNetCore.Mvc;

namespace ACX.EndsPoint.Controllers
{
    [Route("api/ref_service_types")]
    [ApiController]
    public class Ref_Service_Types_Controller : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public Ref_Service_Types_Controller(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET
        [HttpGet]
        public async Task<ActionResult> GetAllServiceTypes()
        {
            var result = await _serviceManager.Ref_Service_Type_Service.GetAllServiceTypes();
            return Ok(result);
        }

        // GET id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _serviceManager.Ref_Service_Type_Service.GetServiceTypeById(id);
            return Ok(result);
        }

        // GET name
        [HttpGet("{name}")]
        public async Task<ActionResult> GetServiceTypeByName(string name)
        {
            var result = await _serviceManager.Ref_Service_Type_Service.GetServiceTypeByName(name);
            return Ok(result);
        }
    }
}