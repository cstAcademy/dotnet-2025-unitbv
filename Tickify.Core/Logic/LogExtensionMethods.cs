using Tickify.Core.Dtos.Requests.Logs;

namespace Tickify.Core.Logic;

public static class LogExtensionMethods
{
    public static bool IsEmpty(this AddLogRequest? request)
    {
        return 
                request?.Log is null
                || string.IsNullOrWhiteSpace(request.Log.Message)
                || string.IsNullOrWhiteSpace(request.Log.StackTrace);
    }
    
    public static bool ExceedsBounds(this AddLogRequest request)
    {
        return request.Log?.Message?.Length > 1000 || request.Log?.StackTrace?.Length > 10_000;
    } 
}