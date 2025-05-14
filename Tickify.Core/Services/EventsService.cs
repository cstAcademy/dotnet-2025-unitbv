using Tickify.Core.Dtos.Requests.Events;
using Tickify.Core.Dtos.Responses.Events;
using Tickify.Core.Mapping;
using Tickify.Database.Repositories;
using Tickify.Infrastructure.Exceptions;

namespace Tickify.Core.Services
{
    public class EventsService(EventsRepository eventsRepository)
    {
        public async Task AddEventAsync(AddEventRequest payload)
        {
            if (payload.EventName.Length > 100)
                throw new WrongInputException("Event name cannot exceed 100 characters.");

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
