using Core.Domain.Entities.Shop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Shop;

/// <summary>
/// EF Core configuration for ShopOrder entity
/// </summary>
public class ShopOrderConfiguration : IEntityTypeConfiguration<ShopOrder>
{
    public void Configure(EntityTypeBuilder<ShopOrder> builder)
    {
        builder.ToTable("ShopOrders");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedNever();

        builder.Property(e => e.OrderNumber)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasIndex(e => e.OrderNumber)
            .IsUnique();

        builder.Property(e => e.CustomerName)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(e => e.CustomerEmail)
            .HasMaxLength(500);

        builder.Property(e => e.CustomerPhone)
            .HasMaxLength(100);

        builder.Property(e => e.DeliveryAddress)
            .HasMaxLength(2000);

        builder.Property(e => e.TotalAmount)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.Property(e => e.DiscountAmount)
            .HasColumnType("decimal(18,2)");

        builder.Property(e => e.DeliveryCost)
            .HasColumnType("decimal(18,2)");

        builder.Property(e => e.FinalAmount)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.Property(e => e.IpAddress)
            .HasMaxLength(50);

        builder.Property(e => e.UserAgent)
            .HasMaxLength(1000);

        builder.Property(e => e.OrderDate)
            .IsRequired();

        builder.Property(e => e.RowVersion)
            .IsRowVersion();

        // Relationships
        builder.HasOne(e => e.ShopOrderStatus)
            .WithMany(s => s.Orders)
            .HasForeignKey(e => e.ShopOrderStatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ShopDelivery)
            .WithMany(d => d.Orders)
            .HasForeignKey(e => e.ShopDeliveryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ShopDiscount)
            .WithMany(d => d.Orders)
            .HasForeignKey(e => e.ShopDiscountId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(e => e.OrderItems)
            .WithOne(oi => oi.ShopOrder)
            .HasForeignKey(oi => oi.ShopOrderId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.Payments)
            .WithOne(p => p.ShopOrder)
            .HasForeignKey(p => p.ShopOrderId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
