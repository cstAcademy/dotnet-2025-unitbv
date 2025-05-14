using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using Tickify.Database.Context;
using Tickify.Database.Dtos;
using Tickify.Database.Entities;
using Tickify.Database.QueryExtensions;

namespace Tickify.Database.Repositories;

public class EventsRepository(TickifyDatabaseContext tickifyDatabaseContext) : BaseRepository<Event>(tickifyDatabaseContext)
{
    public async Task AddAsync(Event entity)
    {
        tickifyDatabaseContext.Events.Add(entity);
        await SaveChangesAsync();
    }

    public async Task<List<Event>> GetFilteredAsync(EventsFilteringDto filters, EventsSortingDto sortingOption)
    {
        var results = await tickifyDatabaseContext.Events
            .Include(e => e.Tickets)
                .ThenInclude(e => e.TicketPrices)
             .Include(e => e.Tickets)
                .ThenInclude(e => e.UserTickets)

            .Where(e => e.DeletedAt == null)
            .FilterByEventStartDate(filters.DateRange)
            .SearchBy(filters.SearchValue)

            .SortBy(sortingOption)

            .Skip(filters.Skip)
            .Take(filters.Take)

            .AsNoTracking()
            .ToListAsync();

        return results;
    }
}