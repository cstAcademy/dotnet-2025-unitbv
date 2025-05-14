using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickify.Database.Dtos;

namespace Tickify.Core.Dtos.Requests.Events
{
    public class GetFilteredEventsRequest
    {
        public EventsFilteringDto Filters { get; set; }
        public EventsSortingDto SortingOption { get; set; }
    }
}
