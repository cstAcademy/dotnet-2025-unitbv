using Microsoft.Extensions.DependencyInjection;
using Tickify.Core.Services;

namespace Tickify.Core;

public static class DIConfig
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<LogsService>();
        services.AddScoped<EventsService>();
        services.AddScoped<TicketsService>();
        services.AddSingleton<SingletonService>();
        
        return services;
    }
}