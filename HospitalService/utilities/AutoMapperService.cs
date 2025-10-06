using AutoMapper;
using HospitalService.DTOs;
using HospitalService.Models;
using AutoMapper;
namespace HospitalService.utilities
{
    public class AutoMapperService : Profile
    {
        public AutoMapperService()
        {
            CreateMap<HospitalDto, Hospital>();
            CreateMap<Hospital, HospitalDto>();
        }
    }
}
