using Microsoft.EntityFrameworkCore;
using Tickify.Database.Entities;
using Tickify.Infrastructure.Config;

namespace Tickify.Database.Context;

public class TickifyDatabaseContext : DbContext
{
    public TickifyDatabaseContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(AppConfig.ConnectionStrings?.TickifyDatabase);//.LogTo(Console.WriteLine);

    }

    public DbSet<Log> Logs { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<TicketPrice> TicketPriceHistory { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserTicket> UserTickets { get; set; }
}