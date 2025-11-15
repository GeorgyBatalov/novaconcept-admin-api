using Core.Domain.Entities.Cms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Cms;

/// <summary>
/// EF Core configuration for CmsMenuItem entity
/// </summary>
public class CmsMenuItemConfiguration : IEntityTypeConfiguration<CmsMenuItem>
{
    public void Configure(EntityTypeBuilder<CmsMenuItem> builder)
    {
        builder.ToTable("CmsMenuItems");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedNever();

        builder.Property(e => e.Name)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(e => e.Title)
            .HasMaxLength(1000)
            .IsRequired();

        builder.Property(e => e.Url)
            .HasMaxLength(2000);

        builder.Property(e => e.CssClass)
            .HasMaxLength(500);

        builder.Property(e => e.IconClass)
            .HasMaxLength(500);

        builder.Property(e => e.IsPublic)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(e => e.OpenInNewWindow)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(e => e.Order)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(e => e.RowVersion)
            .IsRowVersion();

        // Self-referencing for hierarchical menu
        builder.HasOne(e => e.ParentMenuItem)
            .WithMany(m => m.ChildMenuItems)
            .HasForeignKey(e => e.ParentMenuItemId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.CmsMenu)
            .WithMany(m => m.MenuItems)
            .HasForeignKey(e => e.CmsMenuId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.CmsPage)
            .WithMany(p => p.MenuItems)
            .HasForeignKey(e => e.CmsPageId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
