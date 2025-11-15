using Core.Domain.Common.Entities;

namespace Core.Domain.Entities.Shop;

/// <summary>
/// Shop order
/// </summary>
public class ShopOrder : EntityBase
{
    /// <summary>
    /// Order number (human-readable)
    /// </summary>
    public virtual string OrderNumber { get; set; } = string.Empty;

    /// <summary>
    /// Order date
    /// </summary>
    public virtual DateTime OrderDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Customer name
    /// </summary>
    public virtual string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Customer email
    /// </summary>
    public virtual string? CustomerEmail { get; set; }

    /// <summary>
    /// Customer phone
    /// </summary>
    public virtual string? CustomerPhone { get; set; }

    /// <summary>
    /// Delivery address
    /// </summary>
    public virtual string? DeliveryAddress { get; set; }

    /// <summary>
    /// Order comment/notes
    /// </summary>
    public virtual string? Comment { get; set; }

    /// <summary>
    /// Total order amount
    /// </summary>
    public virtual decimal TotalAmount { get; set; }

    /// <summary>
    /// Discount amount
    /// </summary>
    public virtual decimal? DiscountAmount { get; set; }

    /// <summary>
    /// Delivery cost
    /// </summary>
    public virtual decimal? DeliveryCost { get; set; }

    /// <summary>
    /// Final amount (total - discount + delivery)
    /// </summary>
    public virtual decimal FinalAmount { get; set; }

    /// <summary>
    /// IP address of customer
    /// </summary>
    public virtual string? IpAddress { get; set; }

    /// <summary>
    /// User agent
    /// </summary>
    public virtual string? UserAgent { get; set; }

    // Navigation properties

    /// <summary>
    /// Order status
    /// </summary>
    public virtual Guid? ShopOrderStatusId { get; set; }
    public virtual ShopOrderStatus? ShopOrderStatus { get; set; }

    /// <summary>
    /// Delivery method
    /// </summary>
    public virtual Guid? ShopDeliveryId { get; set; }
    public virtual ShopDelivery? ShopDelivery { get; set; }

    /// <summary>
    /// Applied discount
    /// </summary>
    public virtual Guid? ShopDiscountId { get; set; }
    public virtual ShopDiscount? ShopDiscount { get; set; }

    /// <summary>
    /// Order items
    /// </summary>
    public virtual ICollection<ShopOrderItem> OrderItems { get; set; } = new List<ShopOrderItem>();

    /// <summary>
    /// Payments for this order
    /// </summary>
    public virtual ICollection<ShopPayment> Payments { get; set; } = new List<ShopPayment>();
}
