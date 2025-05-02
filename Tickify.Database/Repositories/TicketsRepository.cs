using Tickify.Database.Context;
using Tickify.Database.Entities;

namespace Tickify.Database.Repositories
{
    public class TicketsRepository(TickifyDatabaseContext tickifyDatabaseContext) : BaseRepository<Ticket>(tickifyDatabaseContext)
    {
    }

}
