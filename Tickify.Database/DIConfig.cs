using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tickify.Database.Context;
using Tickify.Database.Repositories;

namespace Tickify.Database;

public static class DIConfig
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddDbContext<TickifyDatabaseContext>();
        services.AddScoped<DbContext, TickifyDatabaseContext>();
        services.AddScoped<LogsRepository>();
        
        return services;
    }
}