using Tickify.Core.Dtos.Common.Events;
using Tickify.Core.Dtos.Requests.Events;
using Tickify.Core.Dtos.Responses.Events;
using Tickify.Database.Entities;

namespace Tickify.Core.Mapping
{
    public static class EventsMappingExtensions
    {
        public static Event ToEntity(this AddEventRequest payload)
        {
            var eventEntity = new Event();

            eventEntity.Name = payload.EventName;
            eventEntity.StartDate = payload.StartDate;
            eventEntity.EndDate = payload.EndDate;

            return eventEntity;
        }

        public static List<EventDto> ToEventDtos(this List<Event> entities)
        {
            var results = entities.Select(e => e.ToEventDto()).ToList();

            return results;
        }

        private static EventDto ToEventDto(this Event entity)
        {
            var dto = new EventDto();

            dto.Id = entity.Id;
            dto.EventName = entity.Name;
            dto.StartDate = entity.StartDate;
            dto.EndDate = entity.EndDate;
            dto.AvailableTicketsCount = entity.Tickets.Count();

            return dto;
        }

        public static GetEventDetailsResponse ToGetEventDetailsResponse(this Event entity)
        {
            var dto = new GetEventDetailsResponse();

            dto.Id = entity.Id;
            dto.EventName = entity.Name;
            dto.StartDate = entity.StartDate;
            dto.EndDate = entity.EndDate;
            dto.EndDate = entity.EndDate;

            dto.Tickets = entity.Tickets.Select(t => t.ToTicketDto()).ToList();

            return dto;
        }
    }
}
