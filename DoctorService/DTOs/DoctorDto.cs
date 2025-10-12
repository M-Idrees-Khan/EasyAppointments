namespace DoctorService.DTOs
{
    public class DoctorDto
    {
        public Guid DoctorId { get; set; } = new Guid();
        public Guid HospitalId { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Contact { get; set; } = "";
        public string Specialization { get; set; } = "";
        public string Qualification { get; set; } = "";
        public int Age { get; set; } = 0;
        public int ExperienceYears { get; set; } = 0;
        public string Password { get; set; } = "";
        public string ClinicTime { get; set; } = "";
        public int MaxAppointments { get; set; } = 0;
        public string Image { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
