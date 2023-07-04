using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Update;
using ACX.ServiceContract.Common;
using Microsoft.AspNetCore.Mvc;

namespace ACX.EndsPoint.Controllers
{
    [Route("api/serviceproviders")]
    [ApiController]
    public class ServiceProvidersController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public ServiceProvidersController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        // GET
        [HttpGet]
        public async Task<ActionResult> GetAllServiceProviders()
        {
            var result = await _serviceManager.ServiceProviderService.GetAllServiceProviders();
            return Ok(result);
        }

        // GET id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            var result = await _serviceManager.ServiceProviderService.GetServiceProviderById(id);
            return Ok(result);
        }

        // GET email
        [HttpGet("{email}")]
        public async Task<ActionResult> GetByEmail(string email)
        {
            var result = await _serviceManager.ServiceProviderService.GetServiceProviderByEmail(email);
            return Ok(result);
        }

        // GET regNumber
        [HttpGet("{regNumber}")]
        public async Task<ActionResult> GetByRegNumber(string regNumber)
        {
            var result = await _serviceManager.ServiceProviderService.GerServiceProviderByRegNumber(regNumber);
            return Ok(result);
        }

        // POST 
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ServiceProviderCreationDto serviceProviderCreationDto)
        {
            var result = await _serviceManager.ServiceProviderService.CreateServiceProvider(serviceProviderCreationDto);
            return CreatedAtAction(nameof(GetById), new {id=result.Id});
        }

        // PUT 
        [HttpPut()]
        public ActionResult Put([FromBody] ServiceProviderUpdateDto serviceProviderUpdateDto)
        {
            _serviceManager.ServiceProviderService.UpdateServiceProvider(serviceProviderUpdateDto);
            return NoContent();
        }

        // DELETE 
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeleteServiceProvider(Guid id)
        {
            _serviceManager.ServiceProviderService.DeleteServiceProvider(id);
            return NoContent();
        }
    }
}
