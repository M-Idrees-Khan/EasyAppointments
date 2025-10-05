using HospitalService.Models;

namespace HospitalService.Services
{
    public interface IHospitalService
    {
        Task CreateHospital(Hospital hospital);
        Task<IEnumerable<Hospital>> GetHospitalList();
        Task<Hospital> GetHospitalById(Guid HospitalId);
        Task Update(Hospital Hospital);
        Task Delete(Hospital Hospital);
    }
}
