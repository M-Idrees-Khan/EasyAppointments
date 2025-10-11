using HospitalService.Data;
using HospitalService.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalService.Repositories
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly HospitalDbContext _hospitalDbContext;
        public HospitalRepository(HospitalDbContext hospitalDbContext)
        {
            _hospitalDbContext = hospitalDbContext;
        }
        
        public async Task<IEnumerable<Hospital>> GetHospitalList()
        {
            return await _hospitalDbContext.hospitals.AsNoTracking().ToListAsync();   
        }
        public async Task<Hospital> GetHospitalById(Guid HospitalId)
        {
            return await _hospitalDbContext.hospitals.AsNoTracking().FirstOrDefaultAsync(e=>e.HospitalId==HospitalId);
        }
        public async Task CreateHospital(Hospital hospital)
        {
            await _hospitalDbContext.hospitals.AddAsync(hospital);
            await _hospitalDbContext.SaveChangesAsync();
        }
        public async Task UpdateHospital(Hospital Hospital)
        {
             _hospitalDbContext.Update(Hospital);
            await _hospitalDbContext.SaveChangesAsync();
        }
        public async Task DeleteHospital(Hospital Hospital)
        {
             _hospitalDbContext.Remove(Hospital);
            await _hospitalDbContext.SaveChangesAsync();
        }
    }
}
