using HospitalService.Models;

namespace HospitalService.Repositories
{
    public interface IHospitalRepository
    {
        Task CreateHospital(Hospital hospital);
        Task<IEnumerable<Hospital>> GetHospitalList();
        Task<Hospital> GetHospitalById(Guid HospitalId);
        Task UpdateHospital(Hospital Hospital);
        Task DeleteHospital(Hospital Hospital);
    }
}
