using AutoMapper;
using UserService.DTOs;
using UserService.Models;
using UserService.Repositories;
using UserService.Utilities;

namespace UserService.Services
{
    public class UserServices : IUserService
    {
        private readonly IUserRepository _userRepository;
        User users=new User();
        UserDto usersDto = new UserDto();
        private IMapper _mapper;
        public UserServices(IUserRepository userRepository, IMapper mapper)
        {
                _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<UserDto>> GetUserList()
        {
          IEnumerable<User>userList=await  _userRepository.GetUserList();
            List<UserDto> list = _mapper.Map<List<UserDto>>(userList);
            return list;
        }
        public async Task<UserDto> GetUserById(Guid userId)
        {
          return _mapper.Map<UserDto>(await _userRepository.GetUserById(userId));
        }
        public async Task<string> CreateUser(UserDto userDto)
        {
         users=_mapper.Map<User>(userDto);
         await   _userRepository.CreateUser(users);
            return VTUserService.Success;
        }
        public async Task<string> UpdateUser(UserDto userDto)
        {
            users = _mapper.Map<User>(userDto);
            await _userRepository.UpdateUser(users);
            return VTUserService.Update;
        }
        public async Task<string> DeleteUser(Guid userId)
        {
            users=await _userRepository.GetUserById(userId);
            await _userRepository.DeleteUser(users);
            return VTUserService.Delete;
        }
    }
}
