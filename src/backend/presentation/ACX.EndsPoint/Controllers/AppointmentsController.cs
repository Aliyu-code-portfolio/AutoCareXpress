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
        public async Task<ActionResult> GetAllAppointments()
        {
            var result = await _serviceManager.AppointmentService.GetAllAppointments(false);
            return Ok(result);
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
        public async Task<ActionResult> Post([FromBody] AppointmentCreationDto appointmentsCreationDto)
        {
            var result = await _serviceManager.AppointmentService.CreateAppointment(appointmentsCreationDto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id });
        }

        // DELETE 
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeleteAppointments(int id)
        {
            _serviceManager.AppointmentService.DeleteAppointment(id);
            return NoContent();
        }
    }
}
