using AutoMapper;
using DoctorService.DTOs;
using DoctorService.Models;
using DoctorService.Repositories;
using DoctorService.Utilities;

namespace DoctorService.Services
{
    public class DoctorServices : IDoctorService
    {
        private readonly IDoctorRepository _DoctorRepository;
        Doctor Doctors = new Doctor();
        DoctorDto DoctorsDto = new DoctorDto();
        private IMapper _mapper;
        public DoctorServices(IDoctorRepository DoctorRepository, IMapper mapper)
        {
            _DoctorRepository = DoctorRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DoctorDto>> GetDoctorList()
        {
            IEnumerable<Doctor> DoctorList = await _DoctorRepository.GetDoctorList();
            List<DoctorDto> list = _mapper.Map<List<DoctorDto>>(DoctorList);
            return list;
        }
        public async Task<DoctorDto> GetDoctorById(Guid DoctorId)
        {
            return _mapper.Map<DoctorDto>(await _DoctorRepository.GetDoctorById(DoctorId));
        }
        public async Task<string> CreateDoctor(DoctorDto DoctorDto)
        {
            Doctors = _mapper.Map<Doctor>(DoctorDto);
            await _DoctorRepository.CreateDoctor(Doctors);
            return VTDoctorService.Success;
        }
        public async Task<string> UpdateDoctor(DoctorDto DoctorDto)
        {
            Doctors = _mapper.Map<Doctor>(DoctorDto);
            await _DoctorRepository.UpdateDoctor(Doctors);
            return VTDoctorService.Update;
        }
        public async Task<string> DeleteDoctor(Guid DoctorId)
        {
            Doctors = await _DoctorRepository.GetDoctorById(DoctorId);
            await _DoctorRepository.DeleteDoctor(Doctors);
            return VTDoctorService.Delete;
        }
    }
}
