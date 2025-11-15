using Core.Domain.Entities.Shop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Shop;

/// <summary>
/// EF Core configuration for ShopProduct entity
/// </summary>
public class ShopProductConfiguration : IEntityTypeConfiguration<ShopProduct>
{
    public void Configure(EntityTypeBuilder<ShopProduct> builder)
    {
        builder.ToTable("ShopProducts");

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

        builder.Property(e => e.Price)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.Property(e => e.OldPrice)
            .HasColumnType("decimal(18,2)");

        builder.Property(e => e.Quantity)
            .HasColumnType("decimal(18,2)");

        builder.Property(e => e.Weight)
            .HasColumnType("decimal(18,2)");

        builder.Property(e => e.Length)
            .HasColumnType("decimal(18,2)");

        builder.Property(e => e.Width)
            .HasColumnType("decimal(18,2)");

        builder.Property(e => e.Height)
            .HasColumnType("decimal(18,2)");

        builder.Property(e => e.Url)
            .HasMaxLength(2000);

        builder.Property(e => e.PictureUrl)
            .HasMaxLength(1000);

        builder.Property(e => e.ThumbnailUrl)
            .HasMaxLength(1000);

        builder.Property(e => e.Article)
            .HasMaxLength(500);

        builder.Property(e => e.Keywords)
            .HasMaxLength(1000);

        builder.Property(e => e.Tags)
            .HasMaxLength(1000);

        builder.Property(e => e.IsPublic)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(e => e.Order)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(e => e.RowVersion)
            .IsRowVersion();

        // Relationships
        builder.HasOne(e => e.ShopProductVendor)
            .WithMany(v => v.Products)
            .HasForeignKey(e => e.ShopProductVendorId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(e => e.ProductCategories)
            .WithOne(pc => pc.ShopProduct)
            .HasForeignKey(pc => pc.ShopProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.Photos)
            .WithOne(p => p.ShopProduct)
            .HasForeignKey(p => p.ShopProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.Options)
            .WithOne(o => o.ShopProduct)
            .HasForeignKey(o => o.ShopProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.PropertyValues)
            .WithOne(pv => pv.ShopProduct)
            .HasForeignKey(pv => pv.ShopProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.OrderItems)
            .WithOne(oi => oi.ShopProduct)
            .HasForeignKey(oi => oi.ShopProductId)
            .OnDelete(DeleteBehavior.SetNull);

        // Many-to-many related products (self-reference)
        builder.HasMany(e => e.RelatedProducts)
            .WithMany()
            .UsingEntity(j => j.ToTable("ShopProductRelatedProducts"));
    }
}
