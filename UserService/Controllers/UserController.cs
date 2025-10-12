using Microsoft.AspNetCore.Mvc;
using UserService.DTOs;
using UserService.Services;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getallUsers")]
        public async Task<IActionResult> GetAllUser()
        {
            var users = await _userService.GetUserList();
            return Ok(users);
        }
        [HttpGet("getUserById/{userId}")]
        public async Task<ActionResult> GetUserById(Guid userId)
        {
            var user = await _userService.GetUserById(userId);
            return Ok(user);
        }
        [HttpPost("createUser")]
        public async Task<ActionResult> CreateUser([FromBody] UserDto userDto)
        {
            var result = await _userService.CreateUser(userDto);
            return Ok(result);
        }
        [HttpPatch("updateUser")]
        public async Task<ActionResult> UpdateUser([FromBody] UserDto userDto)
        {
            var result = await _userService.UpdateUser(userDto);
            return Ok(result);
        }
        [HttpDelete("deleteUser/{userId}")]
        public async Task<ActionResult> DeleteUser(Guid userId)
        {
            var result = await _userService.DeleteUser(userId);
            return Ok(result);
        }
    }
}
