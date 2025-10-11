using AutoMapper;
using AppointmentService.DTOs;
using AppointmentService.Models;
using AppointmentService.Repositories;
using AppointmentService.Utilities;

namespace AppointmentService.Services
{
    public class AppointmentServices : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        Appointment Appointments = new Appointment();
        AppointmentDto AppointmentsDto = new AppointmentDto();
        private IMapper _mapper;
        public AppointmentServices(IAppointmentRepository AppointmentRepository, IMapper mapper)
        {
            _appointmentRepository = AppointmentRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AppointmentDto>> GetAppointmentList()
        {
            IEnumerable<Appointment> AppointmentList = await _appointmentRepository.GetAppointmentList();
            List<AppointmentDto> list = _mapper.Map<List<AppointmentDto>>(AppointmentList);
            return list;
        }
        public async Task<AppointmentDto> GetAppointmentById(Guid AppointmentId)
        {
            return _mapper.Map<AppointmentDto>(await _appointmentRepository.GetAppointmentById(AppointmentId));
        }
        public async Task<string> CreateAppointment(AppointmentDto AppointmentDto)
        {
            Appointments = _mapper.Map<Appointment>(AppointmentDto);
            await _appointmentRepository.CreateAppointment(Appointments);
            return VTAppointmentService.Success;
        }
        public async Task<string> UpdateAppointment(AppointmentDto AppointmentDto)
        {
            Appointments = _mapper.Map<Appointment>(AppointmentDto);
            await _appointmentRepository.UpdateAppointment(Appointments);
            return VTAppointmentService.Update;
        }
        public async Task<string> DeleteAppointment(Guid AppointmentId)
        {
            Appointments = await _appointmentRepository.GetAppointmentById(AppointmentId);
            await _appointmentRepository.DeleteAppointment(Appointments);
            return VTAppointmentService.Delete;
        }
    }
}
