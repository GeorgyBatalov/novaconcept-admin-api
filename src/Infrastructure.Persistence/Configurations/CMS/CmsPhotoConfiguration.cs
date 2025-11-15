using Core.Domain.Entities.Cms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Cms;

/// <summary>
/// EF Core configuration for CmsPhoto entity
/// </summary>
public class CmsPhotoConfiguration : IEntityTypeConfiguration<CmsPhoto>
{
    public void Configure(EntityTypeBuilder<CmsPhoto> builder)
    {
        builder.ToTable("CmsPhotos");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedNever();

        builder.Property(e => e.Title)
            .HasMaxLength(1000);

        builder.Property(e => e.Description)
            .HasMaxLength(4000);

        builder.Property(e => e.ImageUrl)
            .HasMaxLength(1000)
            .IsRequired();

        builder.Property(e => e.ThumbnailUrl)
            .HasMaxLength(1000);

        builder.Property(e => e.Order)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(e => e.RowVersion)
            .IsRowVersion();

        builder.HasOne(e => e.CmsPhotoGallery)
            .WithMany(g => g.Photos)
            .HasForeignKey(e => e.CmsPhotoGalleryId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
