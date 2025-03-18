using Microsoft.Extensions.Logging;
using Tickify.Core.Dtos.Requests.Logs;
using Tickify.Database.Entities;

namespace Tickify.Core.Mapping;

public static class LogMappingExtensions
{

    public static Log ToLog(this AddLogRequest request)
    {
        var log = new Log();

        log.Message = request.Log?.Message;
        log.StackTrace = request.Log?.StackTrace;
        log.LogLevel = request.Log?.LogLevel ?? LogLevel.None;

        return log;
    }

    public static GetLogsResponse ToGetLogsResponse(this List<Log> logs)
    {
        var logsDtos = new List<GetLogDto>();

        foreach (var log in logs)
        {
            var dto = log.ToGetLogDto();
            
            logsDtos.Add(dto);
        }

        var result = new GetLogsResponse
        {
            Logs = logsDtos
        };

        return result;
    } 

    public static GetLogDto ToGetLogDto(this Log log)
    {
        var result = new GetLogDto();

        result.Id = log.Id;
        result.Message = log.Message;
        result.StackTrace = log.StackTrace;
        result.CreatedAt = log.CreatedAt;
        result.LogLevel = log.LogLevel;

        return result;
    }
    
}