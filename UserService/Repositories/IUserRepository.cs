using UserService.Models;

namespace UserService.Repositories
{
    public interface IUserRepository
    {
        Task CreateUser(User users);
        Task<IEnumerable<User>> GetUserList();
        Task<User> GetUserById(Guid UserId);
        Task UpdateUser(User users);
        Task DeleteUser(User users);
    }
}
