using Microsoft.AspNetCore.Mvc;
using Tickify.Core.Dtos.Requests.Logs;
using Tickify.Core.Services;
using Tickify.Infrastructure.Base;

namespace Tickify.Api.Controllers;

[Route("logs")]
public class LogsController(LogsService logsService) : BaseController
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