using Core.Domain.Entities.Cms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Cms;

/// <summary>
/// EF Core configuration for CmsMenu entity
/// </summary>
public class CmsMenuConfiguration : IEntityTypeConfiguration<CmsMenu>
{
    public void Configure(EntityTypeBuilder<CmsMenu> builder)
    {
        builder.ToTable("CmsMenus");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedNever();

        builder.Property(e => e.Name)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(e => e.Code)
            .HasMaxLength(500)
            .IsRequired();

        builder.HasIndex(e => e.Code)
            .IsUnique();

        builder.Property(e => e.Title)
            .HasMaxLength(1000)
            .IsRequired();

        builder.Property(e => e.Description)
            .HasMaxLength(4000);

        builder.Property(e => e.RowVersion)
            .IsRowVersion();

        builder.HasMany(e => e.MenuItems)
            .WithOne(m => m.CmsMenu)
            .HasForeignKey(m => m.CmsMenuId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
