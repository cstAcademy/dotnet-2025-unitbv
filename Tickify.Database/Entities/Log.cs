using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;

namespace Tickify.Database.Entities;

public class Log : BaseEntity
{
    [MaxLength(1_000)]
    public string? Message { get; set; }
    
    [MaxLength(10_000)]
    public string? StackTrace { get; set; }
    public LogLevel LogLevel { get; set; }
}