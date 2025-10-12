using Microsoft.EntityFrameworkCore;
using UserService.Data;
using UserService.Models;

namespace UserService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _userDbContext;
        public UserRepository(UserDbContext userDbContext)
        {
             _userDbContext=userDbContext;
        }
        public async Task<IEnumerable<User>> GetUserList()
        {
          return await _userDbContext.Users.ToListAsync();
        }
        public async Task<User> GetUserById(Guid UserId)
        {
            return await _userDbContext.Users.AsNoTracking().FirstOrDefaultAsync(e => e.UserId == UserId);
        }
        public async Task CreateUser(User users)
        {
           await _userDbContext.Users.AddAsync(users);
            await _userDbContext.SaveChangesAsync();
        }
        public async Task UpdateUser(User users)
        {
             _userDbContext.Users.Update(users);
            await _userDbContext.SaveChangesAsync();
        }
        public async Task DeleteUser(User users)
        {
            _userDbContext.Users.Remove(users);
            await _userDbContext.SaveChangesAsync();
        }
    }
}
