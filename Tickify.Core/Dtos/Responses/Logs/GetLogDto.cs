using Microsoft.Extensions.Logging;

namespace Tickify.Core.Dtos.Requests.Logs;

public class GetLogDto
{
    public int Id { get; set; }
    
    public string? Message { get; set; }
    public string? StackTrace { get; set; }
    public LogLevel LogLevel { get; set; }
    
    public DateTime CreatedAt { get; set; }
}