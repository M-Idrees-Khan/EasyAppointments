using AuthService.Data;
using AuthService.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Repositories
{
    public class AuthRepositery : IAuthRepositery
    {
        private readonly AuthDbContext _dbContext;
        private readonly DbSet<Auth> _dbSet; 
        public AuthRepositery(AuthDbContext dbContext)
        {
            _dbContext = dbContext;    
            _dbSet=_dbContext.Set<Auth>();
        }
        public async Task<Auth> verifyEmail(string email)
        {
        return   await _dbContext.Auths.AsNoTracking().FirstOrDefaultAsync(e => e.Email == email);
        }
    }
}
