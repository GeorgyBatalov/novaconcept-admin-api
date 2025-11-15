using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Shop;

/// <summary>
/// Order status (New, Processing, Shipped, Delivered, Cancelled, etc.)
/// </summary>
public class ShopOrderStatus : CodedEntityBase, IEntityWithOrder
{
    /// <summary>
    /// Status title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Status description
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// CSS color for UI display
    /// </summary>
    public virtual string? Color { get; set; }

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    /// <summary>
    /// Is this a final status (order cannot be modified)
    /// </summary>
    public virtual bool IsFinal { get; set; }

    // Navigation properties

    /// <summary>
    /// Orders with this status
    /// </summary>
    public virtual ICollection<ShopOrder> Orders { get; set; } = new List<ShopOrder>();
}
