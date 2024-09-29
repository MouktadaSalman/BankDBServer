namespace DataTierWebServer.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int PhoneNumber { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string? Password { get; set; }
    }
}
