using AutoMapper;
using AppointmentService.DTOs;
using AppointmentService.Models;

namespace AppointmentService.Utilities
{
    public class AutoMapperService : Profile
    {
        public AutoMapperService()
        {
            CreateMap<Appointment, AppointmentDto>();
            CreateMap<AppointmentDto, Appointment>();
        }
    }
}
