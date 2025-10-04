using Microsoft.AspNetCore.Mvc;

namespace HospitalService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HospitalController : ControllerBase
    {
        [HttpGet("getall")]
        public IActionResult GetAllHospitals()
        {
            var hospitals = new[]
            {
                new { Id = 1, Name = "City Hospital", Address = "Main Road" },
                new { Id = 2, Name = "Care Clinic", Address = "Street 123" }
            };

            return Ok(hospitals);
        }
    }
}
