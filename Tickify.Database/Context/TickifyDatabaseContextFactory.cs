using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Tickify.Infrastructure.Config;

namespace Tickify.Database.Context;

public class TickifyDatabaseContextFactory : IDesignTimeDbContextFactory<TickifyDatabaseContext>
    {
        public TickifyDatabaseContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath($"{Directory.GetCurrentDirectory()}")
                .AddJsonFile($"appsettings.Development.json");

            var configuration = builder.Build();
            AppConfig.Init(configuration);
            
            return new TickifyDatabaseContext();
        }
}