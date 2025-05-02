
namespace Tickify.Database.Entities;

public class Ticket : BaseEntity
{
    public TicketTypes TicketType { get; set; }
    
    public int EventId { get; set; }
    
    public Event Event { get; set; }

    public List<TicketPrice> TicketPrices { get; set; } = [];
    public List<UserTicket> UserTickets { get; set; } = [];
}