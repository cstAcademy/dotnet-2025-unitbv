using Microsoft.EntityFrameworkCore;
using Tickify.Database.Context;
using Tickify.Database.Entities;

namespace Tickify.Database.Repositories;

public class EventsRepository : BaseRepository<Event>
{
    public EventsRepository(TickifyDatabaseContext tickifyDatabaseContext) : base(tickifyDatabaseContext)
    {
        this.tickifyDatabaseContext = tickifyDatabaseContext;
        Console.WriteLine("EventsRepository initialized");
    }

    public async Task AddAsync(Event entity)
    {
        tickifyDatabaseContext.Events.Add(entity);
        await SaveChangesAsync();
    }

    public async Task<List<Event>> GetAllAsync()
    {
        var results = await tickifyDatabaseContext.Events
            .Where(e => e.DeletedAt == null)

            .OrderBy(e => e.Name)

            //.AsNoTracking()
            .ToListAsync();

        return results;
    }
}