using AuthService.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AuthService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;
        public AuthController(IHttpClientFactory httpClientFactory, IAuthService authService)
        {
            _httpClient = httpClientFactory.CreateClient();
            _authService = authService;
        }


        [HttpGet("test-hospitals")]
        public async Task<IActionResult> TestHospitals()
        {
            // Call through API Gateway instead of direct Hospital Service
            var response = await _httpClient.GetAsync("https://localhost:7000/hospital/getall");

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
            }

            var result = await response.Content.ReadAsStringAsync();
            return Ok(result);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] string email, string password)
        {
            string result = await _authService.verifyAccount(email, password);
            return Ok(result);
        }
    }
}
