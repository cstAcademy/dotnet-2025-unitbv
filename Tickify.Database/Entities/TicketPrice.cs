using System.ComponentModel.DataAnnotations;

namespace Tickify.Database.Entities;

public class TicketPrice : BaseEntity
{
    public int TicketId { get; set; }
    
    public Ticket Ticket { get; set; }
    
    public decimal Price { get; set; }
    
    /// <summary>
    /// Date & time when the price is ready to take effect.
    /// </summary>
    public DateTime StartDate { get; set; }
}