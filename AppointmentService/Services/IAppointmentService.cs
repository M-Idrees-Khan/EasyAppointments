using AppointmentService.DTOs;

namespace AppointmentService.Services
{
    public interface IAppointmentService
    {
        Task<IEnumerable<AppointmentDto>> GetAppointmentList();
        Task<AppointmentDto> GetAppointmentById(Guid AppointmentId);
        Task<string> CreateAppointment(AppointmentDto appointmentDto);
        Task<string> UpdateAppointment(AppointmentDto appointmentDto);
        Task<string> DeleteAppointment(Guid appointmentId);
    }
}
