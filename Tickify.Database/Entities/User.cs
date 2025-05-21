namespace Tickify.Database.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }

        public List<UserTicket> UserTickets { get; set; } = new List<UserTicket>();
    }
}
