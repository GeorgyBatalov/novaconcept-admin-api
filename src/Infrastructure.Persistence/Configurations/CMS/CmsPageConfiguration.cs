using Core.Domain.Entities.Cms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Cms;

/// <summary>
/// EF Core configuration for CmsPage entity
/// </summary>
public class CmsPageConfiguration : IEntityTypeConfiguration<CmsPage>
{
    public void Configure(EntityTypeBuilder<CmsPage> builder)
    {
        builder.ToTable("CmsPages");

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

        builder.Property(e => e.Keywords)
            .HasMaxLength(1000);

        builder.Property(e => e.Tags)
            .HasMaxLength(1000);

        builder.Property(e => e.MasterPage)
            .HasMaxLength(500);

        builder.Property(e => e.PictureUrl)
            .HasMaxLength(1000);

        builder.Property(e => e.CreatedDate)
            .IsRequired();

        builder.Property(e => e.IssueDate)
            .IsRequired();

        builder.Property(e => e.IsPublic)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(e => e.ShowBreadcrumbs)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(e => e.RowVersion)
            .IsRowVersion();

        // Relationships
        builder.HasOne(e => e.CmsCategory)
            .WithMany(c => c.Pages)
            .HasForeignKey(e => e.CmsCategoryId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(e => e.CmsPhotoGallery)
            .WithMany(g => g.Pages)
            .HasForeignKey(e => e.CmsPhotoGalleryId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(e => e.Comments)
            .WithOne(c => c.CmsPage)
            .HasForeignKey(c => c.CmsPageId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.MenuItems)
            .WithOne(m => m.CmsPage)
            .HasForeignKey(m => m.CmsPageId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
