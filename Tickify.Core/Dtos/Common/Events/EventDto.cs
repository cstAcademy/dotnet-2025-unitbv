using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickify.Core.Dtos.Common.Events
{
    public class EventDto
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
