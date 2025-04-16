using System.ComponentModel.DataAnnotations;

namespace Tickify.Database.Entities;

public class Event : BaseEntity
{
    [MaxLength(1_000)]
    
    public string? Name { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public List<Ticket> Tickets { get; set; } = [];

}