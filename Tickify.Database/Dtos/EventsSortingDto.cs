using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickify.Database.Enums;

namespace Tickify.Database.Dtos
{
    public class EventsSortingDto
    {
        public SortingOrder Order { get; set; }
        public EventsSortingCriteria Criterion { get; set; }
    }
}
