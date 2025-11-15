using Core.Domain.Common.Repositories;
using Core.Domain.Entities.Shop;

namespace Core.Domain.Repositories.Shop;

/// <summary>
/// Repository for shop orders
/// </summary>
public interface IShopOrderRepository : IRepository<ShopOrder>
{
    /// <summary>
    /// Get order by order number
    /// </summary>
    Task<ShopOrder?> GetByOrderNumberAsync(string orderNumber, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get orders by status
    /// </summary>
    Task<IEnumerable<ShopOrder>> GetByStatusAsync(Guid statusId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get orders by customer email
    /// </summary>
    Task<IEnumerable<ShopOrder>> GetByCustomerEmailAsync(string email, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get recent orders
    /// </summary>
    Task<IEnumerable<ShopOrder>> GetRecentAsync(int count, CancellationToken cancellationToken = default);
}
