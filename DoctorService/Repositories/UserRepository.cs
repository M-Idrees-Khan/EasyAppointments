using Microsoft.EntityFrameworkCore;
using DoctorService.Data;
using DoctorService.Models;

namespace DoctorService.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DoctorDbContext _DoctorDbContext;
        public DoctorRepository(DoctorDbContext DoctorDbContext)
        {
            _DoctorDbContext = DoctorDbContext;
        }
        public async Task<IEnumerable<Doctor>> GetDoctorList()
        {
            return await _DoctorDbContext.Doctors.ToListAsync();
        }
        public async Task<Doctor> GetDoctorById(Guid DoctorId)
        {
            return await _DoctorDbContext.Doctors.AsNoTracking().FirstOrDefaultAsync(e => e.DoctorId == DoctorId);
        }
        public async Task CreateDoctor(Doctor Doctors)
        {
            await _DoctorDbContext.Doctors.AddAsync(Doctors);
            await _DoctorDbContext.SaveChangesAsync();
        }
        public async Task UpdateDoctor(Doctor Doctors)
        {
            _DoctorDbContext.Doctors.Update(Doctors);
            await _DoctorDbContext.SaveChangesAsync();
        }
        public async Task DeleteDoctor(Doctor Doctors)
        {
            _DoctorDbContext.Doctors.Remove(Doctors);
            await _DoctorDbContext.SaveChangesAsync();
        }
    }
}
