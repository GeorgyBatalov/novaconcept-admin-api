using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Shop;

/// <summary>
/// Delivery method (Courier, Pickup, Post, etc.)
/// </summary>
public class ShopDelivery : CodedEntityBase, IEntityWithPublicStatus, IEntityWithOrder
{
    /// <summary>
    /// Delivery method title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Delivery description
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Delivery cost
    /// </summary>
    public virtual decimal? Cost { get; set; }

    /// <summary>
    /// Free delivery from this amount
    /// </summary>
    public virtual decimal? FreeFromAmount { get; set; }

    /// <summary>
    /// Estimated delivery time
    /// </summary>
    public virtual string? EstimatedTime { get; set; }

    /// <summary>
    /// Indicates if delivery method is publicly available
    /// </summary>
    public virtual bool IsPublic { get; set; } = true;

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    // Navigation properties

    /// <summary>
    /// Orders using this delivery method
    /// </summary>
    public virtual ICollection<ShopOrder> Orders { get; set; } = new List<ShopOrder>();
}
