using AuthService.Models;
using AuthService.Repositories;

namespace AuthService.Services
{
    public class AuthServices:IAuthService
    {
        protected  IAuthRepositery _authRepositery;
        public AuthServices(IAuthRepositery authRepositery)
        { 
                _authRepositery = authRepositery;
        }
        public async Task<string> verifyAccount(string email,string password)
        {
         Auth auth= await _authRepositery.verifyEmail(email);
            if (auth!=null)
            {
                if (auth.Password == password)
                {
                    return "Login Successfully";
                }
                else
                {
                    return "Invalid Password";
                }
            }
            else
            {
              return  "Account Not Found";
            }
        }
    }
}
