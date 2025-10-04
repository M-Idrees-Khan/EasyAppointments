namespace AuthService.DTOs
{
    public class AuthDto
    {
        public Guid AdminId { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string Contact { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
