using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Shop;

/// <summary>
/// Product property group (e.g., "Technical Specifications")
/// </summary>
public class ShopProductPropertyGroup : NamedEntityBase, IEntityWithOrder
{
    /// <summary>
    /// Group title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    // Navigation properties

    /// <summary>
    /// Properties in this group
    /// </summary>
    public virtual ICollection<ShopProductProperty> Properties { get; set; } = new List<ShopProductProperty>();
}

/// <summary>
/// Product property definition (e.g., "Weight", "Color")
/// </summary>
public class ShopProductProperty : NamedEntityBase, IEntityWithOrder
{
    /// <summary>
    /// Property title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Property unit (e.g., "kg", "cm")
    /// </summary>
    public virtual string? Unit { get; set; }

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    // Navigation properties

    /// <summary>
    /// Property group
    /// </summary>
    public virtual Guid? ShopProductPropertyGroupId { get; set; }
    public virtual ShopProductPropertyGroup? ShopProductPropertyGroup { get; set; }

    /// <summary>
    /// Property values for products
    /// </summary>
    public virtual ICollection<ShopProductPropertyValue> PropertyValues { get; set; } = new List<ShopProductPropertyValue>();
}

/// <summary>
/// Product property value (join entity with value)
/// </summary>
public class ShopProductPropertyValue : EntityBase
{
    /// <summary>
    /// Property value
    /// </summary>
    public virtual string Value { get; set; } = string.Empty;

    // Navigation properties

    /// <summary>
    /// Product
    /// </summary>
    public virtual Guid ShopProductId { get; set; }
    public virtual ShopProduct ShopProduct { get; set; } = null!;

    /// <summary>
    /// Property definition
    /// </summary>
    public virtual Guid ShopProductPropertyId { get; set; }
    public virtual ShopProductProperty ShopProductProperty { get; set; } = null!;
}
