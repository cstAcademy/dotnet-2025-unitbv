using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickify.Core.Dtos.Common.Events;
using Tickify.Core.Dtos.Common.Tickets;

namespace Tickify.Core.Dtos.Responses.Events
{
    public class GetEventDetailsResponse : EventDto
    {
        public List<TicketDto> Tickets { get; set; } = new List<TicketDto>();
    }
}
