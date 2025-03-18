using Tickify.Core.Dtos.Requests.Logs;
using Tickify.Core.Logic;
using Tickify.Core.Mapping;
using Tickify.Database.Repositories;

namespace Tickify.Core.Services;

public class LogsService(LogsRepository logsRepository)
{
    public Task AddLogAsync(AddLogRequest request)
    {
        if (request.IsEmpty()) throw new ArgumentNullException();
        if (request.ExceedsBounds()) throw new ArgumentOutOfRangeException();
        
        var newLog = request.ToLog();
    
        logsRepository.Insert(newLog);
        
        return logsRepository.SaveChangesAsync();
    }

    public async Task<GetLogsResponse> GetLogsAsync()
    {
        var logs = await logsRepository.GetAllAsync();
        
        var result = logs.ToGetLogsResponse();

        return result;
    }
}