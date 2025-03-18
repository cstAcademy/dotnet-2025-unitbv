using Tickify.Database.Context;
using Tickify.Database.Entities;

namespace Tickify.Database.Repositories;

public class LogsRepository(TickifyDatabaseContext databaseContext) : BaseRepository<Log>(databaseContext)
{
    
}