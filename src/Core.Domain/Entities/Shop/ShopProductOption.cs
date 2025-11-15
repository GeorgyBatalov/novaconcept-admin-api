using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Shop;

/// <summary>
/// Product option (e.g., Size, Color)
/// </summary>
public class ShopProductOption : EntityBase, IEntityWithOrder
{
    /// <summary>
    /// Option name (e.g., "Size", "Color")
    /// </summary>
    public virtual string Name { get; set; } = string.Empty;

    /// <summary>
    /// Option type
    /// </summary>
    public virtual string? Type { get; set; }

    /// <summary>
    /// Is option required for purchase
    /// </summary>
    public virtual bool IsRequired { get; set; }

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    // Navigation properties

    /// <summary>
    /// Product this option belongs to
    /// </summary>
    public virtual Guid ShopProductId { get; set; }
    public virtual ShopProduct ShopProduct { get; set; } = null!;

    /// <summary>
    /// Available values for this option
    /// </summary>
    public virtual ICollection<ShopProductOptionItem> OptionItems { get; set; } = new List<ShopProductOptionItem>();
}

/// <summary>
/// Product option value (e.g., "Small", "Red")
/// </summary>
public class ShopProductOptionItem : EntityBase, IEntityWithOrder
{
    /// <summary>
    /// Option value
    /// </summary>
    public virtual string Value { get; set; } = string.Empty;

    /// <summary>
    /// Price modifier (can be negative for discounts)
    /// </summary>
    public virtual decimal? PriceModifier { get; set; }

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    // Navigation properties

    /// <summary>
    /// Option this item belongs to
    /// </summary>
    public virtual Guid ShopProductOptionId { get; set; }
    public virtual ShopProductOption ShopProductOption { get; set; } = null!;
}
