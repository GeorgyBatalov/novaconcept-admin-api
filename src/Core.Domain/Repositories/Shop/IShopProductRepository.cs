using Core.Domain.Common.Repositories;
using Core.Domain.Entities.Shop;

namespace Core.Domain.Repositories.Shop;

/// <summary>
/// Repository for shop products
/// </summary>
public interface IShopProductRepository : IRepository<ShopProduct>
{
    /// <summary>
    /// Get product by code (slug)
    /// </summary>
    Task<ShopProduct?> GetByCodeAsync(string code, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get published products
    /// </summary>
    Task<IEnumerable<ShopProduct>> GetPublishedAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get products by category
    /// </summary>
    Task<IEnumerable<ShopProduct>> GetByCategoryAsync(Guid categoryId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get products by vendor
    /// </summary>
    Task<IEnumerable<ShopProduct>> GetByVendorAsync(Guid vendorId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search products by keyword
    /// </summary>
    Task<IEnumerable<ShopProduct>> SearchAsync(string keyword, CancellationToken cancellationToken = default);
}
