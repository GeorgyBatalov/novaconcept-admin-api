using Core.Domain.Common.Entities;

namespace Core.Domain.Entities.Shop;

/// <summary>
/// Order item (product in order)
/// </summary>
public class ShopOrderItem : EntityBase
{
    /// <summary>
    /// Product name (snapshot at order time)
    /// </summary>
    public virtual string ProductName { get; set; } = string.Empty;

    /// <summary>
    /// Product code (snapshot at order time)
    /// </summary>
    public virtual string? ProductCode { get; set; }

    /// <summary>
    /// Unit price (snapshot at order time)
    /// </summary>
    public virtual decimal UnitPrice { get; set; }

    /// <summary>
    /// Quantity ordered
    /// </summary>
    public virtual decimal Quantity { get; set; } = 1;

    /// <summary>
    /// Total price (unit price * quantity)
    /// </summary>
    public virtual decimal TotalPrice { get; set; }

    /// <summary>
    /// Discount applied to this item
    /// </summary>
    public virtual decimal? DiscountAmount { get; set; }

    // Navigation properties

    /// <summary>
    /// Order this item belongs to
    /// </summary>
    public virtual Guid ShopOrderId { get; set; }
    public virtual ShopOrder ShopOrder { get; set; } = null!;

    /// <summary>
    /// Product (reference, may be null if product deleted)
    /// </summary>
    public virtual Guid? ShopProductId { get; set; }
    public virtual ShopProduct? ShopProduct { get; set; }

    /// <summary>
    /// Selected options for this order item
    /// </summary>
    public virtual ICollection<ShopOrderItemOption> SelectedOptions { get; set; } = new List<ShopOrderItemOption>();
}

/// <summary>
/// Selected option for order item (e.g., Size: Large, Color: Red)
/// </summary>
public class ShopOrderItemOption : EntityBase
{
    /// <summary>
    /// Option name (snapshot at order time)
    /// </summary>
    public virtual string OptionName { get; set; } = string.Empty;

    /// <summary>
    /// Option value (snapshot at order time)
    /// </summary>
    public virtual string OptionValue { get; set; } = string.Empty;

    /// <summary>
    /// Price modifier
    /// </summary>
    public virtual decimal? PriceModifier { get; set; }

    // Navigation properties

    /// <summary>
    /// Order item this option belongs to
    /// </summary>
    public virtual Guid ShopOrderItemId { get; set; }
    public virtual ShopOrderItem ShopOrderItem { get; set; } = null!;
}
