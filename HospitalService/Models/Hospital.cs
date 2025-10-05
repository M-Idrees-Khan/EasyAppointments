using System.Reflection.Metadata.Ecma335;

namespace HospitalService.Models
{
    public class Hospital
    {
        public Guid HospitalId { get; set; } = new Guid();
        public string HospitalName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Address { get; set; } = "";
        public string Contact { get; set; } = "";
    }
}
