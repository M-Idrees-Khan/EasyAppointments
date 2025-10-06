namespace AuthService.Services
{
    public interface IAuthService
    {
        Task<string> verifyAccount(string email, string password);
    }
}
