using HospitalService.Data;
using HospitalService.Models;
using HospitalService.Repositories;

namespace HospitalService.Services
{
    public class HospitalService
    {
        private readonly HospitalRepositery _hospitalRepositery;
        public HospitalService(HospitalRepositery hospitalRepositery)
        {
            _hospitalRepositery = hospitalRepositery;
        }
        public async Task CreateHospital(Hospital hospital)
        {
          await  _hospitalRepositery.CreateHospital(hospital);
        }
        public async Task<IEnumerable<Hospital>> GetHospitalList()
        {
            return await _hospitalRepositery.GetHospitalList();
        }
        public async Task<Hospital> GetHospitalById(Guid HospitalId)
        {
            return await _hospitalRepositery.GetHospitalById(HospitalId);
        }

        public async Task Update(Hospital Hospital)
        {
            await _hospitalRepositery.Update(Hospital);
        }
        public async Task Delete(Hospital Hospital)
        {
          await  _hospitalRepositery.Delete(Hospital);
        }
    }
}
