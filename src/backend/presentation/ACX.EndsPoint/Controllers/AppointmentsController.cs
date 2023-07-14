using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Update;
using ACX.EndsPoint.ActionFilters;
using ACX.ServiceContract.Common;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
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
        //private readonly User.
        public AppointmentsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET
        [HttpGet]
        [HttpHead]
        [Authorize(Roles ="Manager")]
        public async Task<ActionResult> GetAllAppointments([FromQuery] AppointmentRequestParameters requestParameters)
        {
            var result = await _serviceManager.AppointmentService.GetAllAppointments(requestParameters, false);
            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(result.MetaData));

            return Ok(result.Appointments);
        }

        [HttpGet("user/{id}")]
        [Authorize]
        public async Task<ActionResult> GetAllUserAppointments(string id, [FromQuery] AppointmentRequestParameters requestParameters)
        {
            var result = await _serviceManager.AppointmentService.GetAllUserAppointments(id, requestParameters, false);
            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(result.MetaData));

            return Ok(result.Appointments);
        }

        [HttpGet("provider/{id:Guid}")]
        [Authorize(Roles = "Provider")]
        [Authorize(Roles = "Manager")]
        public async Task<ActionResult> GetAllProviderAppointments(string id, [FromQuery] AppointmentRequestParameters requestParameters)
        {
            var result = await _serviceManager.AppointmentService.GetAllServiceProviderAppointments(id, requestParameters, false);
            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(result.MetaData));

            return Ok(result.Appointments);
        }

        // GET id
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _serviceManager.AppointmentService.GetAppointmentById(id);
            return Ok(result);
        }

        [HttpPut("{id}/status/{flag}")]
        [Authorize]
        public async Task<ActionResult> Post(int id, bool flag)
        {
            await _serviceManager.AppointmentService.UpdateStatus(id,flag);
            return NoContent();
        }

        [HttpPut("{id}/rate/{rating}")]
        [Authorize(Roles ="User")]
        public async Task<ActionResult> Post(int id, int rating)
        {
            if(rating <0 || rating > 5)
            {
                return BadRequest("Cannot be lower than 0 or greater than 5");
            }
            await _serviceManager.AppointmentService.Rate(id, rating);
            return NoContent();
        }

        // POST 
        [HttpPost]
        [Authorize(Roles = "User")]
        [ServiceFilter(typeof(ValidationActionFilter))]
        public async Task<ActionResult> Post([FromBody] AppointmentCreationDto appointmentsCreationDto)
        {
            var result = await _serviceManager.AppointmentService.CreateAppointment(appointmentsCreationDto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id},result);
        }

        // DELETE 
        [HttpDelete("{id:Guid}")]
        [Authorize]
        public async Task<ActionResult> DeleteAppointments(int id)
        {
            await _serviceManager.AppointmentService.DeleteAppointment(id);
            return NoContent();
        }
        [HttpOptions]
        [Authorize]
        public IActionResult Options()
        {
            Response.Headers.Add("Allow", "GET, OPTIONS, POST");
            return Ok();
        }
    }
}
