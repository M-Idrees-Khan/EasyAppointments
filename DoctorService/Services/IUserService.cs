using DoctorService.DTOs;

namespace DoctorService.Services
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorDto>> GetDoctorList();
        Task<DoctorDto> GetDoctorById(Guid DoctorId);
        Task<string> CreateDoctor(DoctorDto DoctorDto);
        Task<string> UpdateDoctor(DoctorDto DoctorDto);
        Task<string> DeleteDoctor(Guid DoctorId);
    }
}
