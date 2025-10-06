using HospitalService.DTOs;
using HospitalService.Models;
using HospitalService.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HospitalService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HospitalController : ControllerBase
    {private readonly IHospitalService _hospitalService;
        public HospitalController(IHospitalService hospitalService)
        {
                _hospitalService = hospitalService;
        }
        [HttpGet("getallHospitals")]
        public async Task<IActionResult> GetAllHospitals()
        {
           var hospitals=await _hospitalService.GetHospitalList();
            return Ok(hospitals);
        }
        [HttpGet("getHospitalById/{hospitalId}")]
        public async Task<ActionResult> GetHospitalById(Guid hospitalId)
        {
            var hospital = await _hospitalService.GetHospitalById(hospitalId);
            return Ok(hospital);
        }
        [HttpPost("createHospital")]
        public async Task<ActionResult>CreateHospital([FromBody] Hospital hospital)
        {
           await _hospitalService.CreateHospital(hospital);
            return Ok();
        }
        [HttpPatch("updateHospital")]
        public async Task<ActionResult> UpdateHospital([FromBody] Hospital hospital)
        {
            await _hospitalService.Update(hospital);
            return Ok();
        }
        [HttpDelete("deleteHospital/{hospitalId}")]
        public async Task<ActionResult> DeleteHospital(Guid hospitalId)
        {
            var hospital = await _hospitalService.GetHospitalById(hospitalId);
            await _hospitalService.Delete(hospital);
            return Ok();
        }
    }
}
