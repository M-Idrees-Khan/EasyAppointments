using AuthService.Models;

namespace AuthService.Repositories
{
    public interface IAuthRepositery
    {
        Task<Auth> verifyEmail(string email);
    }
}
