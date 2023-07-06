﻿using ACX.ServiceContract.Common;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ACX.EndsPoint.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/doyouknow")]
    [ApiController]
    public class DoYouKnowController:ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public DoYouKnowController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET
        [HttpGet]
        public async Task<ActionResult> GetAllDoYouKnows()
        {
            var result = await _serviceManager.DoYouKnowService.GetAllDoYouKnow();
            return Ok(result);
        }

        // GET id
        [HttpGet("latest")]
        public async Task<ActionResult> GetByLatestDoYouKnows()
        {
            var result = await _serviceManager.DoYouKnowService.GetLatestDoYouKnow();
            return Ok(result);
        }
    }
}
