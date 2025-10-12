using AppointmentService.Models;

namespace AppointmentService.Repositories
{
    public interface IAppointmentRepository
    {
        Task CreateAppointment(Appointment appointments);
        Task<IEnumerable<Appointment>> GetAppointmentList();
        Task<Appointment> GetAppointmentById(Guid AppointmentId);
        Task UpdateAppointment(Appointment appointments);
        Task DeleteAppointment(Appointment appointments);
    }
}
