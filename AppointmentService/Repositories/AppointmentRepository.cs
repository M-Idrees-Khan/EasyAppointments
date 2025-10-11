using Microsoft.EntityFrameworkCore;
using AppointmentService.Data;
using AppointmentService.Models;

namespace AppointmentService.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppointmentDbContext _appointmentDbContext;
        public AppointmentRepository(AppointmentDbContext AppointmentDbContext)
        {
            _appointmentDbContext = AppointmentDbContext;
        }
        public async Task<IEnumerable<Appointment>> GetAppointmentList()
        {
            return await _appointmentDbContext.Appointments.ToListAsync();
        }
        public async Task<Appointment> GetAppointmentById(Guid AppointmentId)
        {
            return await _appointmentDbContext.Appointments.AsNoTracking().FirstOrDefaultAsync(e => e.AppointmentId == AppointmentId);
        }
        public async Task CreateAppointment(Appointment appointments)
        {
            await _appointmentDbContext.Appointments.AddAsync(appointments);
            await _appointmentDbContext.SaveChangesAsync();
        }
        public async Task UpdateAppointment(Appointment appointments)
        {
            _appointmentDbContext.Appointments.Update(appointments);
            await _appointmentDbContext.SaveChangesAsync();
        }
        public async Task DeleteAppointment(Appointment appointments)
        {
            _appointmentDbContext.Appointments.Remove(appointments);
            await _appointmentDbContext.SaveChangesAsync();
        }
    }
}
