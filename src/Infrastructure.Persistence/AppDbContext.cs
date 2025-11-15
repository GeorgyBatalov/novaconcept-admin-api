using Core.Domain.Entities.Cms;
using Core.Domain.Entities.Constructor;
using Core.Domain.Entities.Shop;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

/// <summary>
/// Application database context for NovaConcept CMS
/// </summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    #region CMS DbSets

    public DbSet<CmsPage> CmsPages => Set<CmsPage>();
    public DbSet<CmsCategory> CmsCategories => Set<CmsCategory>();
    public DbSet<CmsNewsItem> CmsNewsItems => Set<CmsNewsItem>();
    public DbSet<CmsComment> CmsComments => Set<CmsComment>();
    public DbSet<CmsPhotoGallery> CmsPhotoGalleries => Set<CmsPhotoGallery>();
    public DbSet<CmsPhoto> CmsPhotos => Set<CmsPhoto>();
    public DbSet<CmsMenu> CmsMenus => Set<CmsMenu>();
    public DbSet<CmsMenuItem> CmsMenuItems => Set<CmsMenuItem>();

    #endregion

    #region Shop DbSets

    public DbSet<ShopProduct> ShopProducts => Set<ShopProduct>();
    public DbSet<Category> ShopCategories => Set<Category>();
    public DbSet<ShopProductCategory> ShopProductCategories => Set<ShopProductCategory>();
    public DbSet<ShopProductVendor> ShopProductVendors => Set<ShopProductVendor>();
    public DbSet<ShopProductPhoto> ShopProductPhotos => Set<ShopProductPhoto>();
    public DbSet<ShopProductOption> ShopProductOptions => Set<ShopProductOption>();
    public DbSet<ShopProductOptionItem> ShopProductOptionItems => Set<ShopProductOptionItem>();
    public DbSet<ShopProductProperty> ShopProductProperties => Set<ShopProductProperty>();
    public DbSet<ShopProductPropertyGroup> ShopProductPropertyGroups => Set<ShopProductPropertyGroup>();
    public DbSet<ShopProductPropertyValue> ShopProductPropertyValues => Set<ShopProductPropertyValue>();
    public DbSet<ShopOrder> ShopOrders => Set<ShopOrder>();
    public DbSet<ShopOrderItem> ShopOrderItems => Set<ShopOrderItem>();
    public DbSet<ShopOrderItemOption> ShopOrderItemOptions => Set<ShopOrderItemOption>();
    public DbSet<ShopOrderStatus> ShopOrderStatuses => Set<ShopOrderStatus>();
    public DbSet<ShopDelivery> ShopDeliveries => Set<ShopDelivery>();
    public DbSet<ShopDiscount> ShopDiscounts => Set<ShopDiscount>();
    public DbSet<ShopDiscountType> ShopDiscountTypes => Set<ShopDiscountType>();
    public DbSet<ShopPayment> ShopPayments => Set<ShopPayment>();
    public DbSet<ShopPaymentType> ShopPaymentTypes => Set<ShopPaymentType>();

    #endregion

    #region Constructor DbSets

    public DbSet<ConstructorOrder> ConstructorOrders => Set<ConstructorOrder>();
    public DbSet<ConstructorStep> ConstructorSteps => Set<ConstructorStep>();
    public DbSet<ConstructorStepProperty> ConstructorStepProperties => Set<ConstructorStepProperty>();
    public DbSet<ConstructorStepPropertyGroup> ConstructorStepPropertyGroups => Set<ConstructorStepPropertyGroup>();
    public DbSet<ConstructorStepPropertyType> ConstructorStepPropertyTypes => Set<ConstructorStepPropertyType>();
    public DbSet<ConstructorStepPropertyAvailableValue> ConstructorStepPropertyAvailableValues => Set<ConstructorStepPropertyAvailableValue>();
    public DbSet<ConstructorStepPropertyValue> ConstructorStepPropertyValues => Set<ConstructorStepPropertyValue>();

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Apply all configurations from current assembly
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        // Apply additional conventions if needed
        ApplyConventions(modelBuilder);
    }

    private void ApplyConventions(ModelBuilder modelBuilder)
    {
        // Set default schema if needed
        // modelBuilder.HasDefaultSchema("dbo");

        // Disable cascade delete by convention (we set it explicitly in configurations)
        foreach (var relationship in modelBuilder.Model.GetEntityTypes()
            .SelectMany(e => e.GetForeignKeys()))
        {
            if (relationship.DeleteBehavior == DeleteBehavior.Cascade)
            {
                // Already set explicitly in configurations
            }
        }
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        // Update ModifiedDate for modified entities
        var entries = ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Modified)
            .ToList();

        foreach (var entry in entries)
        {
            if (entry.Entity is Core.Domain.Common.Entities.EntityBase entity)
            {
                entity.ModifiedDate = DateTime.UtcNow;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}
