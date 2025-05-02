using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickify.Core.Dtos.Requests.Tickets;
using Tickify.Core.Mapping;
using Tickify.Database.Repositories;

namespace Tickify.Core.Services
{
    public class TicketsService(TicketsRepository ticketsRepository)
    {
        public async Task AddTicketAsync(AddTicketRequest request)
        {
            var ticket = request.ToEntity();

            ticketsRepository.Insert(ticket);
            await ticketsRepository.SaveChangesAsync();
        }
    }
}
