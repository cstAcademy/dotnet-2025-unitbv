using Tickify.Database.Context;
using Tickify.Database.Entities;

namespace Tickify.Database.Repositories;

public class EventsRepository(TickifyDatabaseContext databaseContext) : BaseRepository<Event>(databaseContext)
{
    
}