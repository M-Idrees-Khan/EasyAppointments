namespace AppointmentService.Models
{
    public class Appointment
    {
        public Guid AppointmentId { get; set; } = new Guid();
        public Guid UserId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid HospitalId { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string AppointmentDate { get; set; } = "";
        public int AppointmentNo { get; set; } = 0;
        public string Contact { get; set; } = "";
        public string Address { get; set; } = "";
        public int Age { get; set; } = 0; //calculate from DOB
        public string Gender { get; set; } = "";
        public string DateOfBirth { get; set; } = "";
        public string Status { get; set; } = "";
        public string CreatedAt { get; set; } = "";

    }
}
