using AutoMapper;
using UserService.DTOs;
using UserService.Models;

namespace UserService.Utilities
{
    public class AutoMapperService:Profile
    {
        public AutoMapperService()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
