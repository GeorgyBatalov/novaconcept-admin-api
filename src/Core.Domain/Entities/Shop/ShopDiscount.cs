using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Shop;

/// <summary>
/// Discount/promo code
/// </summary>
public class ShopDiscount : CodedEntityBase, IEntityWithPublicStatus
{
    /// <summary>
    /// Discount title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Discount description
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Promo code
    /// </summary>
    public virtual string? PromoCode { get; set; }

    /// <summary>
    /// Discount type (percentage, fixed amount)
    /// </summary>
    public virtual Guid? ShopDiscountTypeId { get; set; }
    public virtual ShopDiscountType? ShopDiscountType { get; set; }

    /// <summary>
    /// Discount value (percentage or fixed amount)
    /// </summary>
    public virtual decimal DiscountValue { get; set; }

    /// <summary>
    /// Minimum order amount to apply discount
    /// </summary>
    public virtual decimal? MinOrderAmount { get; set; }

    /// <summary>
    /// Start date
    /// </summary>
    public virtual DateTime? StartDate { get; set; }

    /// <summary>
    /// End date
    /// </summary>
    public virtual DateTime? EndDate { get; set; }

    /// <summary>
    /// Maximum usage count
    /// </summary>
    public virtual int? MaxUsageCount { get; set; }

    /// <summary>
    /// Current usage count
    /// </summary>
    public virtual int UsageCount { get; set; }

    /// <summary>
    /// Indicates if discount is publicly available
    /// </summary>
    public virtual bool IsPublic { get; set; } = true;

    // Navigation properties

    /// <summary>
    /// Orders using this discount
    /// </summary>
    public virtual ICollection<ShopOrder> Orders { get; set; } = new List<ShopOrder>();
}

/// <summary>
/// Discount type (Percentage, Fixed Amount)
/// </summary>
public class ShopDiscountType : CodedEntityBase
{
    /// <summary>
    /// Type title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    // Navigation properties

    /// <summary>
    /// Discounts of this type
    /// </summary>
    public virtual ICollection<ShopDiscount> Discounts { get; set; } = new List<ShopDiscount>();
}
