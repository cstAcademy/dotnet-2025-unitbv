namespace Tickify.Database.Entities
{
    public class UserTicket : BaseEntity
    {
        public int UserId { get; set; }
        public int TicketId { get; set; }
        public decimal Price { get; set; }
        public User User { get; set; }
        public Ticket Ticket { get; set; }
    }
}
