using Core.Domain.Common.Entities;

namespace Core.Domain.Entities.Shop;

/// <summary>
/// Product vendor/manufacturer
/// </summary>
public class ShopProductVendor : CodedEntityBase
{
    /// <summary>
    /// Vendor title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Vendor description
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Logo URL
    /// </summary>
    public virtual string? LogoUrl { get; set; }

    /// <summary>
    /// Website URL
    /// </summary>
    public virtual string? WebsiteUrl { get; set; }

    // Navigation properties

    /// <summary>
    /// Products from this vendor
    /// </summary>
    public virtual ICollection<ShopProduct> Products { get; set; } = new List<ShopProduct>();
}
