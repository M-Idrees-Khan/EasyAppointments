using AppointmentService.DTOs;
using AppointmentService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService AppointmentService)
        {
            _appointmentService = AppointmentService;
        }
        [HttpGet("getallAppointments")]
        public async Task<IActionResult> GetAllAppointment()
        {
            var Appointments = await _appointmentService.GetAppointmentList();
            return Ok(Appointments);
        }
        [HttpGet("getAppointmentById/{AppointmentId}")]
        public async Task<ActionResult> GetAppointmentById(Guid AppointmentId)
        {
            var Appointment = await _appointmentService.GetAppointmentById(AppointmentId);
            return Ok(Appointment);
        }
        [HttpPost("createAppointment")]
        public async Task<ActionResult> CreateAppointment([FromBody] AppointmentDto AppointmentDto)
        {
            var result = await _appointmentService.CreateAppointment(AppointmentDto);
            return Ok(result);
        }
        [HttpPatch("updateAppointment")]
        public async Task<ActionResult> UpdateAppointment([FromBody] AppointmentDto AppointmentDto)
        {
            var result = await _appointmentService.UpdateAppointment(AppointmentDto);
            return Ok(result);
        }
        [HttpDelete("deleteAppointment/{AppointmentId}")]
        public async Task<ActionResult> DeleteAppointment(Guid AppointmentId)
        {
            var result = await _appointmentService.DeleteAppointment(AppointmentId);
            return Ok(result);
        }
    }
}
