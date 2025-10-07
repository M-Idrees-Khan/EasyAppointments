using HospitalService.DTOs;
using HospitalService.Services;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult>CreateHospital([FromBody] HospitalDto hospitalDto)
        {
           var result= await _hospitalService.CreateHospital(hospitalDto);
            return Ok(result);
        }
        [HttpPatch("updateHospital")]
        public async Task<ActionResult> UpdateHospital([FromBody] HospitalDto hospitalDto)
        {
          var result=  await _hospitalService.UpdateHospital(hospitalDto);
            return Ok(result);
        }
        [HttpDelete("deleteHospital/{hospitalId}")]
        public async Task<ActionResult> DeleteHospital(Guid hospitalId)
        {
          var result=  await _hospitalService.DeleteHospital(hospitalId);
            return Ok(result);
        }
    }
}
