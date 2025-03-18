using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tickify.Database.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? ModifiedAt { get; set; }
    
    public DateTime? DeletedAt { get; set; }
}

public class BaseEntityConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
{
    private static void ConfigureBase(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(x => x.Id)
            .IsClustered(false)
            .HasName("PK_" + typeof(T).Name + "Id");

        builder.Property(x => x.CreatedAt)
            .IsRequired()
            .HasColumnType("datetime2");

        builder.Property(x => x.ModifiedAt)
            .HasColumnType("datetime2")
            .IsRequired(false);

        builder.Property(x => x.DeletedAt)
            .HasColumnType("datetime2")
            .IsRequired(false);

        builder.HasIndex(x => x.DeletedAt)
            .HasFilter("[DeletedAt] IS NULL")
            .HasDatabaseName("IX_DeletedAt");
    }
    
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        ConfigureBase(builder);
    }
}