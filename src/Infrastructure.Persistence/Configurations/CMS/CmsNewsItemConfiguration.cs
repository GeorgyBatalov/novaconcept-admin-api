using Core.Domain.Entities.Cms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Cms;

/// <summary>
/// EF Core configuration for CmsNewsItem entity
/// </summary>
public class CmsNewsItemConfiguration : IEntityTypeConfiguration<CmsNewsItem>
{
    public void Configure(EntityTypeBuilder<CmsNewsItem> builder)
    {
        builder.ToTable("CmsNewsItems");

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

        builder.Property(e => e.PictureUrl)
            .HasMaxLength(1000);

        builder.Property(e => e.IssueDate)
            .IsRequired();

        builder.Property(e => e.IsPublic)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(e => e.RowVersion)
            .IsRowVersion();

        // Relationships
        builder.HasOne(e => e.CmsCategory)
            .WithMany(c => c.NewsItems)
            .HasForeignKey(e => e.CmsCategoryId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(e => e.CmsPhotoGallery)
            .WithMany(g => g.NewsItems)
            .HasForeignKey(e => e.CmsPhotoGalleryId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(e => e.Comments)
            .WithOne(c => c.CmsNewsItem)
            .HasForeignKey(c => c.CmsNewsItemId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
