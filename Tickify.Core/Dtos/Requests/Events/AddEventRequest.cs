using Tickify.Database.Entities;

namespace Tickify.Core.Dtos.Requests.Events
{
    public class AddEventRequest
    {
        public string EventName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
