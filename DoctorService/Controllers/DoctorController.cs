using DoctorService.DTOs;
using DoctorService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _DoctorService;
        public DoctorController(IDoctorService DoctorService)
        {
            _DoctorService = DoctorService;
        }
        [HttpGet("getallDoctors")]
        public async Task<IActionResult> GetAllDoctor()
        {
            var Doctors = await _DoctorService.GetDoctorList();
            return Ok(Doctors);
        }
        [HttpGet("getDoctorById/{DoctorId}")]
        public async Task<ActionResult> GetDoctorById(Guid DoctorId)
        {
            var Doctor = await _DoctorService.GetDoctorById(DoctorId);
            return Ok(Doctor);
        }
        [HttpPost("createDoctor")]
        public async Task<ActionResult> CreateDoctor([FromBody] DoctorDto DoctorDto)
        {
            var result = await _DoctorService.CreateDoctor(DoctorDto);
            return Ok(result);
        }
        [HttpPatch("updateDoctor")]
        public async Task<ActionResult> UpdateDoctor([FromBody] DoctorDto DoctorDto)
        {
            var result = await _DoctorService.UpdateDoctor(DoctorDto);
            return Ok(result);
        }
        [HttpDelete("deleteDoctor/{DoctorId}")]
        public async Task<ActionResult> DeleteDoctor(Guid DoctorId)
        {
            var result = await _DoctorService.DeleteDoctor(DoctorId);
            return Ok(result);
        }
    }
}
