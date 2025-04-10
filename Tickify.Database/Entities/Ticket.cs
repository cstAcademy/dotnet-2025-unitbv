
namespace Tickify.Database.Entities;

public class Ticket : BaseEntity
{
    public TicketTypes TicketType { get; set; }
    
    public int EventId { get; set; }
    
    public required Event Event { get; set; }
    public User User { get; set; }

    public List<TicketPrice> TicketPrices { get; set; } = [];
}