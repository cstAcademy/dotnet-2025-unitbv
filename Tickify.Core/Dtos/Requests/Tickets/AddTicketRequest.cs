using Tickify.Database.Entities;

namespace Tickify.Core.Dtos.Requests.Tickets
{
    public class AddTicketRequest
    {
        public int EventId { get; set; }
        public TicketTypes TicketType { get; set; }
        public decimal Price { get; set; }
        public DateTime SaleStartDate { get; set; }
    }
}
