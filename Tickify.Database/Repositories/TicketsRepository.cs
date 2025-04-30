using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickify.Database.Context;
using Tickify.Database.Entities;

namespace Tickify.Database.Repositories
{
    public class TicketsRepository : BaseRepository<Ticket>
    {
        public TicketsRepository(TickifyDatabaseContext tickifyDatabaseContext) : base(tickifyDatabaseContext)
        {
            Console.WriteLine("TicketsRepository initialized");
        }
    }
}
