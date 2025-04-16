using Tickify.Core.Dtos.Common.Events;

namespace Tickify.Core.Dtos.Responses.Events
{
    public class GetEventsResponse
    {
        public List<EventDto> Events { get; set; } = new List<EventDto>();
    }
}
