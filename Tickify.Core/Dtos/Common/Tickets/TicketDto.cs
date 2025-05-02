using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickify.Database.Entities;

namespace Tickify.Core.Dtos.Common.Tickets
{
    public class TicketDto
    {
        public TicketTypes TicketType { get; set; }
        public decimal? Price { get; set; }
    }
}
