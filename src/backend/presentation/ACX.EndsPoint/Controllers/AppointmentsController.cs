using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Update;
using ACX.EndsPoint.ActionFilters;
using ACX.ServiceContract.Common;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace ACX.EndsPoint.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/appointments")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public AppointmentsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET
        [HttpGet]
        [HttpHead]
        public async Task<ActionResult> GetAllAppointments([FromQuery] AppointmentRequestParameters requestParameters)
        {
            var result = await _serviceManager.AppointmentService.GetAllAppointments(requestParameters, false);
            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(result.MetaData));

            return Ok(result.Appointments);
        }

        [HttpGet("user/{id:Guid}")]
        public async Task<ActionResult> GetAllUserAppointments(Guid id, [FromQuery] AppointmentRequestParameters requestParameters)
        {
            var result = await _serviceManager.AppointmentService.GetAllUserAppointments(id, requestParameters, false);
            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(result.MetaData));

            return Ok(result.Appointments);
        }

        [HttpGet("provider/{id:Guid}")]
        public async Task<ActionResult> GetAllProviderAppointments(Guid id, [FromQuery] AppointmentRequestParameters requestParameters)
        {
            var result = await _serviceManager.AppointmentService.GetAllServiceProviderAppointments(id, requestParameters, false);
            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(result.MetaData));

            return Ok(result.Appointments);
        }

        // GET id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _serviceManager.AppointmentService.GetAppointmentById(id);
            return Ok(result);
        }

        // POST 
        [HttpPost]
        [ServiceFilter(typeof(ValidationActionFilter))]
        public async Task<ActionResult> Post([FromBody] AppointmentCreationDto appointmentsCreationDto)
        {
            var result = await _serviceManager.AppointmentService.CreateAppointment(appointmentsCreationDto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id, result });
        }

        // DELETE 
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeleteAppointments(int id)
        {
            await _serviceManager.AppointmentService.DeleteAppointment(id);
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
