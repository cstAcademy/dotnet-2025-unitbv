using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;

namespace Tickify.Database.Entities;

public class Log : BaseEntity
{
    public string? Message { get; set; }
    
    public string? StackTrace { get; set; }
    public LogLevel LogLevel { get; set; }
}

public class LogConfig : BaseEntityConfig<Log>
{
    public override void Configure(EntityTypeBuilder<Log> builder)
    {
        builder.ToTable("Logs");

        builder.Property(x => x.Message)
            .HasDefaultValue(null)
            .HasMaxLength(1_000);
        
        builder.Property(x => x.StackTrace)
            .HasDefaultValue(null)
            .HasMaxLength(10_000);

        builder.HasIndex(x => x.LogLevel)
            .HasDatabaseName("IX_Logs_LogLevel");
        
        base.Configure(builder);
    }
}