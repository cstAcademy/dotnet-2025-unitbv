using System.ComponentModel.DataAnnotations;

namespace Tickify.Database.Entities;

public class Event : BaseEntity
{
    [MaxLength(1_000)]
    
    public string? Name { get; set; }

    public List<Ticket> Tickets { get; set; } = [];

}