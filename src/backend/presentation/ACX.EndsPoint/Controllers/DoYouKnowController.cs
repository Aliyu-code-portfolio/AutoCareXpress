using ACX.ServiceContract.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ACX.EndsPoint.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/doyouknow")]
    [ApiController]
    [Authorize]
    public class DoYouKnowController:ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public DoYouKnowController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET
        [HttpGet("all")]
        public async Task<ActionResult> GetAllDoYouKnows()
        {
            var result = await _serviceManager.DoYouKnowService.GetAllDoYouKnow();
            return Ok(result);
        }

        // GET id
        [HttpGet("all/latest")]
        public async Task<ActionResult> GetByLatestDoYouKnows()
        {
            var result = await _serviceManager.DoYouKnowService.GetLatestDoYouKnow();
            return Ok(result);
        }

        // GET id
        [HttpGet()]
        public async Task<ActionResult> GetRandomCarTip()
        {
            var result = await _serviceManager.DoYouKnowService.GetRandomDoYouKnow();
            return Ok(result);
        }
    }
}
