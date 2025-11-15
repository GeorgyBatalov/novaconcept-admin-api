using Core.Domain.Entities.Cms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Cms;

/// <summary>
/// EF Core configuration for CmsComment entity
/// </summary>
public class CmsCommentConfiguration : IEntityTypeConfiguration<CmsComment>
{
    public void Configure(EntityTypeBuilder<CmsComment> builder)
    {
        builder.ToTable("CmsComments");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedNever();

        builder.Property(e => e.AuthorName)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(e => e.AuthorEmail)
            .HasMaxLength(500);

        builder.Property(e => e.Body)
            .IsRequired();

        builder.Property(e => e.IpAddress)
            .HasMaxLength(50);

        builder.Property(e => e.IsApproved)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(e => e.RowVersion)
            .IsRowVersion();

        // Self-referencing for threaded comments
        builder.HasOne(e => e.ParentComment)
            .WithMany(c => c.Replies)
            .HasForeignKey(e => e.ParentCommentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.CmsPage)
            .WithMany(p => p.Comments)
            .HasForeignKey(e => e.CmsPageId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(e => e.CmsNewsItem)
            .WithMany(n => n.Comments)
            .HasForeignKey(e => e.CmsNewsItemId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
