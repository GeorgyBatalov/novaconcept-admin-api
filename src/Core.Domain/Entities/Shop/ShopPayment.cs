using Core.Domain.Common.Entities;

namespace Core.Domain.Entities.Shop;

/// <summary>
/// Payment for an order
/// </summary>
public class ShopPayment : EntityBase
{
    /// <summary>
    /// Payment amount
    /// </summary>
    public virtual decimal Amount { get; set; }

    /// <summary>
    /// Payment date
    /// </summary>
    public virtual DateTime PaymentDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Payment status (Pending, Completed, Failed, Refunded)
    /// </summary>
    public virtual string Status { get; set; } = "Pending";

    /// <summary>
    /// External transaction ID (from payment gateway)
    /// </summary>
    public virtual string? TransactionId { get; set; }

    /// <summary>
    /// Payment comment/notes
    /// </summary>
    public virtual string? Comment { get; set; }

    // Navigation properties

    /// <summary>
    /// Order this payment belongs to
    /// </summary>
    public virtual Guid ShopOrderId { get; set; }
    public virtual ShopOrder ShopOrder { get; set; } = null!;

    /// <summary>
    /// Payment type/method
    /// </summary>
    public virtual Guid? ShopPaymentTypeId { get; set; }
    public virtual ShopPaymentType? ShopPaymentType { get; set; }
}

/// <summary>
/// Payment type (Cash, Card, Online, etc.)
/// </summary>
public class ShopPaymentType : CodedEntityBase
{
    /// <summary>
    /// Payment type title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Payment type description
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Is active/available
    /// </summary>
    public virtual bool IsActive { get; set; } = true;

    // Navigation properties

    /// <summary>
    /// Payments of this type
    /// </summary>
    public virtual ICollection<ShopPayment> Payments { get; set; } = new List<ShopPayment>();
}
