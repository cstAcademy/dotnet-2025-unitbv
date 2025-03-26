using Microsoft.Extensions.Logging;

namespace Tickify.Core.Dtos.Requests.Logs;

public class AddLogDto
{
    public string? Message { get; set; }
    public string? StackTrace { get; set; }
    public LogLevel LogLevel { get; set; }
}