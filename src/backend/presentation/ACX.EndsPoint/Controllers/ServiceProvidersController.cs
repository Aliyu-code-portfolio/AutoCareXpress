using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Update;
using ACX.ServiceContract.Common;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace ACX.EndsPoint.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/providers")]
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
        [HttpHead]
        public async Task<ActionResult> GetAllServiceProviders([FromQuery] ProviderRequestParameter requestParameter)
        {
            var result = await _serviceManager.ServiceProviderService.GetAllServiceProviders(requestParameter);
            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(result.MetaData));

            return Ok(result.Providers);
        }

        // GET id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            var result = await _serviceManager.ServiceProviderService.GetServiceProviderById(id);
            return Ok(result);
        }

        // GET email
        [HttpGet("email/{email}")]
        public async Task<ActionResult> GetByEmail(string email)
        {
            var result = await _serviceManager.ServiceProviderService.GetServiceProviderByEmail(email);
            return Ok(result);
        }

        // GET regNumber
        [HttpGet("regnumber/{regNumber}")]
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
        public async Task<ActionResult> Put([FromBody] ServiceProviderUpdateDto serviceProviderUpdateDto)
        {
            await _serviceManager.ServiceProviderService.UpdateServiceProvider(serviceProviderUpdateDto);
            return NoContent();
        }

        // DELETE 
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteServiceProvider(Guid id)
        {
            await _serviceManager.ServiceProviderService.DeleteServiceProvider(id);
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
