using HospitalService.Models;

namespace HospitalService.Repositories
{
    public interface IHospitalRepositery
    {
        Task CreateHospital(Hospital hospital);
        Task<IEnumerable<Hospital>> GetHospitalList();
        Task<Hospital> GetHospitalById(Guid HospitalId);
        Task Update(Hospital Hospital);
        Task Delete(Hospital Hospital);
    }
}
