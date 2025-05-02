using Tickify.Core.Dtos.Common.Events;
using Tickify.Core.Dtos.Requests.Events;
using Tickify.Core.Dtos.Requests.Logs;
using Tickify.Core.Dtos.Responses.Events;
using Tickify.Core.Mapping;
using Tickify.Database.Repositories;

namespace Tickify.Core.Services
{
    public class EventsService(EventsRepository eventsRepository)
    {
        public async Task AddEventAsync(AddEventRequest payload)
        {
            var newEvent = payload.ToEntity();
            newEvent.CreatedAt = DateTime.UtcNow;

            await eventsRepository.AddAsync(newEvent);
        }

        public async Task<GetEventsResponse> GetEventsAsync()
        {
            var events = await eventsRepository.GetAllAsync();

            var result = new GetEventsResponse();
            result.Events = events.ToEventDtos();

            return result;
        }
    }
}
