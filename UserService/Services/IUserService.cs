using UserService.DTOs;

namespace UserService.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetUserList();
        Task<UserDto> GetUserById(Guid userId);
        Task<string> CreateUser(UserDto userDto);
        Task<string> UpdateUser(UserDto userDto);
        Task<string> DeleteUser(Guid userId);
    }
}
