using Microsoft.EntityFrameworkCore;
using Tickify.Database.Entities;
using Tickify.Infrastructure.Config;

namespace Tickify.Database.Context;

public class TickifyDatabaseContext : DbContext
{
    public TickifyDatabaseContext() { }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(AppConfig.ConnectionStrings?.TickifyDatabase);

        if (AppConfig.ConsoleLogQueries)
        {
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BaseEntityConfig<>).Assembly);
    }
    
    public DbSet<Log> Logs { get; set; }
}