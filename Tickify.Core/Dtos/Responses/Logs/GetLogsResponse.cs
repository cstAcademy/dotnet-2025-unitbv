namespace Tickify.Core.Dtos.Requests.Logs;

public class GetLogsResponse
{
    public List<GetLogDto> Logs { get; set; } = []; 
}