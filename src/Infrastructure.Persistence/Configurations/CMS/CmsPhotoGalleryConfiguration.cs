using Core.Domain.Entities.Cms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Cms;

/// <summary>
/// EF Core configuration for CmsPhotoGallery entity
/// </summary>
public class CmsPhotoGalleryConfiguration : IEntityTypeConfiguration<CmsPhotoGallery>
{
    public void Configure(EntityTypeBuilder<CmsPhotoGallery> builder)
    {
        builder.ToTable("CmsPhotoGalleries");

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

        builder.Property(e => e.CoverImageUrl)
            .HasMaxLength(1000);

        builder.Property(e => e.IsPublic)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(e => e.RowVersion)
            .IsRowVersion();

        builder.HasMany(e => e.Photos)
            .WithOne(p => p.CmsPhotoGallery)
            .HasForeignKey(p => p.CmsPhotoGalleryId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.Pages)
            .WithOne(p => p.CmsPhotoGallery)
            .HasForeignKey(p => p.CmsPhotoGalleryId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(e => e.NewsItems)
            .WithOne(n => n.CmsPhotoGallery)
            .HasForeignKey(n => n.CmsPhotoGalleryId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
