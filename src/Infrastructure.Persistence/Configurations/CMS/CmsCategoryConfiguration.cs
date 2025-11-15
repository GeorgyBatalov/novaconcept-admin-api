using Core.Domain.Entities.Cms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Cms;

/// <summary>
/// EF Core configuration for CmsCategory entity
/// </summary>
public class CmsCategoryConfiguration : IEntityTypeConfiguration<CmsCategory>
{
    public void Configure(EntityTypeBuilder<CmsCategory> builder)
    {
        builder.ToTable("CmsCategories");

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

        builder.Property(e => e.Description)
            .HasMaxLength(4000);

        builder.Property(e => e.PictureUrl)
            .HasMaxLength(1000);

        builder.Property(e => e.IsPublic)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(e => e.RowVersion)
            .IsRowVersion();

        // Self-referencing relationship for hierarchy
        builder.HasOne(e => e.ParentCategory)
            .WithMany(c => c.ChildCategories)
            .HasForeignKey(e => e.ParentCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.Pages)
            .WithOne(p => p.CmsCategory)
            .HasForeignKey(p => p.CmsCategoryId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(e => e.NewsItems)
            .WithOne(n => n.CmsCategory)
            .HasForeignKey(n => n.CmsCategoryId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
