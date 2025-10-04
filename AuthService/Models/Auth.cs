namespace AuthService.Models
{
    public class Auth
    {
        public Guid AdminId { get; set; } = new Guid();
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string Contact { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
