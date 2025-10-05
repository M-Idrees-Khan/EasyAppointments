using HospitalService.Data;
using HospitalService.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalService.Repositories
{
    public class HospitalRepositery : IHospitalRepositery
    {
        private readonly HospitalDbContext _hospitalDbContext;
        public HospitalRepositery(HospitalDbContext hospitalDbContext)
        {
            _hospitalDbContext = hospitalDbContext;
        }
        public async Task CreateHospital(Hospital hospital)
        {
            await _hospitalDbContext.hospitals.AddAsync(hospital);
            await _hospitalDbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<Hospital>> GetHospitalList()
        {
            return await _hospitalDbContext.hospitals.ToListAsync();   
        }
        public async Task<Hospital> GetHospitalById(Guid HospitalId)
        {
            return await _hospitalDbContext.hospitals.Where(e => e.HospitalId == HospitalId).FirstOrDefaultAsync();
        }

        public async Task Update(Hospital Hospital)
        {
             _hospitalDbContext.Update(Hospital);
            await _hospitalDbContext.SaveChangesAsync();
        }
        public async Task Delete(Hospital Hospital)
        {
             _hospitalDbContext.Remove(Hospital);
            await _hospitalDbContext.SaveChangesAsync();
        }
    }
}
