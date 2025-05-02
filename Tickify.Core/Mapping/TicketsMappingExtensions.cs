using Tickify.Core.Dtos.Common.Tickets;
using Tickify.Core.Dtos.Requests.Tickets;
using Tickify.Database.Entities;

namespace Tickify.Core.Mapping
{
    public static class TicketsMappingExtensions
    {
        public static Ticket ToEntity(this AddTicketRequest payload)
        {
            var eventEntity = new Ticket();

            eventEntity.TicketType = payload.TicketType;
            eventEntity.EventId = payload.EventId;
            eventEntity.CreatedAt = DateTime.UtcNow;

            eventEntity.TicketPrices.Add(new TicketPrice
            {
                Price = payload.Price,
                StartDate = payload.SaleStartDate,
                CreatedAt = DateTime.UtcNow
            });

            return eventEntity;
        }

        public static TicketDto ToTicketDto(this Ticket entity)
        {
            var dto = new TicketDto();

            dto.TicketType = entity.TicketType;

            var lastTicketPrice = entity.TicketPrices
                .Where(e => e.StartDate <= DateTime.UtcNow)
                .OrderByDescending(x => x.StartDate)
                .FirstOrDefault();

            dto.Price = lastTicketPrice?.Price;

            return dto;
        }
    }
}
