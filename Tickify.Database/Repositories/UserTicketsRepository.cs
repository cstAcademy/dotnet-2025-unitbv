using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickify.Database.Context;
using Tickify.Database.Entities;

namespace Tickify.Database.Repositories
{
    public class UserTicketsRepository : BaseRepository<UserTicket>
    {
        public UserTicketsRepository(TickifyDatabaseContext tickifyDatabaseContext) : base(tickifyDatabaseContext)
        {
            Console.WriteLine("UserTicketsRepository initialized");
        }
    }
}

