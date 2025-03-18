using Microsoft.AspNetCore.Mvc;
using Tickify.Core.Dtos.Requests.Logs;
using Tickify.Core.Services;

namespace Tickify.Api.Controllers;

[ApiController]
[Route("[controller]")]

public class LogsController(LogsService logsService) : ControllerBase
{
    
    [HttpPost("add-log")]
    public async Task<IActionResult> AddLog([FromBody] AddLogRequest request)
    {
        await logsService.AddLogAsync(request);
        return Ok();
    }

    [HttpGet("get-logs")]
    public async Task<IActionResult> GetLogs()
    {
        var result = await logsService.GetLogsAsync();
        return Ok(result);
    }
}