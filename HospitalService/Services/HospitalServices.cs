using AutoMapper;
using HospitalService.DTOs;
using HospitalService.Models;
using HospitalService.Repositories;
using HospitalService.utilities;

namespace HospitalService.Services
{
    public class HospitalServices:IHospitalService
    {
        private readonly IHospitalRepository _hospitalRepositery;
        private IMapper _mapper;
        private Hospital hospital=new Hospital();
        List<HospitalDto> hospitalDtos = new List<HospitalDto>();
        public HospitalServices(IHospitalRepository hospitalRepositery,IMapper mapper)
        {
            _mapper = mapper;
            _hospitalRepositery = hospitalRepositery;
        }
        public async Task<IEnumerable<HospitalDto>> GetHospitalList()
        {
            IEnumerable<Hospital>hospital= await _hospitalRepositery.GetHospitalList();
            hospitalDtos=_mapper.Map<List<HospitalDto>>(hospital);
            return hospitalDtos;
        }
        public async Task<HospitalDto> GetHospitalById(Guid hospitalId)
        {
            hospital= await _hospitalRepositery.GetHospitalById(hospitalId);
         return   _mapper.Map<HospitalDto>(hospital);
        }
        public async Task<string> CreateHospital(HospitalDto hospitaldto)
        {
            hospital = _mapper.Map<Hospital>(hospitaldto);
            await _hospitalRepositery.CreateHospital(hospital);
            return VTHospitalService.Success;
        }
        public async Task<string> UpdateHospital(HospitalDto hospitalDto)
        {
            hospital = _mapper.Map<Hospital>(hospitalDto);
            await _hospitalRepositery.UpdateHospital(hospital);
            return VTHospitalService.Update;
        }
        public async Task<string> DeleteHospital(Guid hospitalId)
        {
            hospital = await _hospitalRepositery.GetHospitalById(hospitalId);
          await  _hospitalRepositery.DeleteHospital(hospital);
            return VTHospitalService.Delete;
        }
    }
}
