using Microsoft.AspNetCore.Mvc;
using Tickify.Core.Dtos.Requests.Events;
using Tickify.Core.Services;

namespace Tickify.Api.Controllers
{
    [ApiController]
    [Route("events")]

    public class EventsController(EventsService eventsService) : ControllerBase
    {
        [HttpPost("add-event")]
        public async Task<IActionResult> AddEvent([FromBody] AddEventRequest payload)
        {
            await eventsService.AddEventAsync(payload);
            return Ok("Event added successfully");
        }

        [HttpPost("get-events")]
        public async Task<IActionResult> GetEvents(GetEventsRequest payload)
        {
            var result = await eventsService.GetEventsAsync(payload);
            return Ok(result);
        }
    }
}
