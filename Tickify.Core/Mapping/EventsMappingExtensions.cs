using Tickify.Core.Dtos.Requests.Events;
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
    }
}
