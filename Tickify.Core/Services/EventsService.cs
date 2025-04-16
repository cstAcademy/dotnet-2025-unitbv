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

            var result = new GetEventsResponse
            {
                Events = events.Select(e => new EventDto
                {
                    Id = e.Id,
                    EventName = e.Name,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                }).ToList()
            };

            return result;
        }
    }
}
