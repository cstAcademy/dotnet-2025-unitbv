using Microsoft.AspNetCore.Mvc;
using Tickify.Core.Dtos.Requests.Events;
using Tickify.Core.Dtos.Requests.Tickets;
using Tickify.Core.Services;

namespace Tickify.Api.Controllers
{
    [ApiController]
    [Route("tickets")]

    public class TicketsController(TicketsService ticketsService) : ControllerBase
    {
        [HttpPost("add-ticket")]
        public async Task<IActionResult> AddTicket([FromBody] AddTicketRequest payload)
        {
            await ticketsService.AddTicketAsync(payload);
            return Ok("Ticket added successfully");
        }

    }
}
