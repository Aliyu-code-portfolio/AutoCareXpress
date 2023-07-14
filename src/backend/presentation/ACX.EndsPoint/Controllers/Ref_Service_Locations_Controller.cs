using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Update;
using ACX.ServiceContract.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ACX.EndsPoint.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/servicelocations")]
    [ApiController]
    //[Authorize]
    public class Ref_Service_Locations_Controller : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public Ref_Service_Locations_Controller(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET
        [HttpGet]
        public async Task<ActionResult> GetAllServiceLocations()
        {
            var result = await _serviceManager.Ref_Service_Location_Service.GetAllServiceLocations();
            return Ok(result);
        }

        // GET id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _serviceManager.Ref_Service_Location_Service.GetServiceLocationById(id);
            return Ok(result);
        }

        // GET name
        [HttpGet("name/{name}",Name = "GetServiceLocationByName")]
        public async Task<ActionResult> GetServiceLocationByName(string name)
        {
            var result = await _serviceManager.Ref_Service_Location_Service.GerServiceLocationByName(name);
            return Ok(result);
        }
        [HttpOptions]
        public IActionResult Options()
        {
            Response.Headers.Add("Allow", "GET, OPTIONS");
            return Ok();
        }
    }
}
