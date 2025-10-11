using DoctorService.Models;

namespace DoctorService.Repositories
{
    public interface IDoctorRepository
    {
        Task CreateDoctor(Doctor Doctors);
        Task<IEnumerable<Doctor>> GetDoctorList();
        Task<Doctor> GetDoctorById(Guid DoctorId);
        Task UpdateDoctor(Doctor Doctors);
        Task DeleteDoctor(Doctor Doctors);
    }
}
