using HospitalService.DTOs;

namespace HospitalService.Services
{
    public interface IHospitalService
    {
        Task<IEnumerable<HospitalDto>> GetHospitalList();
        Task<HospitalDto> GetHospitalById(Guid hospitalId);
        Task<string> CreateHospital(HospitalDto hospitalDto);
        Task<string> UpdateHospital(HospitalDto hospitalDto);
        Task<string> DeleteHospital(Guid hospitalId);
    }
}
