using AutoMapper;
using DoctorService.DTOs;
using DoctorService.Models;

namespace UserService.Utilities
{
    public class AutoMapperService : Profile
    {
        public AutoMapperService()
        {
            CreateMap<Doctor, DoctorDto>();
            CreateMap<DoctorDto, Doctor>();
        }
    }
}
