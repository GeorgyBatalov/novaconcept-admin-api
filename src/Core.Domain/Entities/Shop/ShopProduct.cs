using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;
using Core.Domain.Entities.Cms;

namespace Core.Domain.Entities.Shop;

/// <summary>
/// Shop product
/// </summary>
public class ShopProduct : CodedEntityBase, IEntityWithPublicStatus, IEntityWithOrder
{
    /// <summary>
    /// Product title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Short description
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Full product description (HTML)
    /// </summary>
    public virtual string? Body { get; set; }

    /// <summary>
    /// Product price
    /// </summary>
    public virtual decimal Price { get; set; }

    /// <summary>
    /// Old price (for showing discounts)
    /// </summary>
    public virtual decimal? OldPrice { get; set; }

    /// <summary>
    /// Available quantity in stock
    /// </summary>
    public virtual decimal? Quantity { get; set; }

    /// <summary>
    /// Product URL
    /// </summary>
    public virtual string? Url { get; set; }

    /// <summary>
    /// Main picture URL
    /// </summary>
    public virtual string? PictureUrl { get; set; }

    /// <summary>
    /// Thumbnail picture URL
    /// </summary>
    public virtual string? ThumbnailUrl { get; set; }

    /// <summary>
    /// Publication date
    /// </summary>
    public virtual DateTime? IssueDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Indicates if product is publicly visible
    /// </summary>
    public virtual bool IsPublic { get; set; } = true;

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    /// <summary>
    /// SEO keywords
    /// </summary>
    public virtual string? Keywords { get; set; }

    /// <summary>
    /// Tags for categorization
    /// </summary>
    public virtual string? Tags { get; set; }

    /// <summary>
    /// Product article/SKU
    /// </summary>
    public virtual string? Article { get; set; }

    /// <summary>
    /// Product weight (kg)
    /// </summary>
    public virtual decimal? Weight { get; set; }

    /// <summary>
    /// Product length (cm)
    /// </summary>
    public virtual decimal? Length { get; set; }

    /// <summary>
    /// Product width (cm)
    /// </summary>
    public virtual decimal? Width { get; set; }

    /// <summary>
    /// Product height (cm)
    /// </summary>
    public virtual decimal? Height { get; set; }

    // Navigation properties

    /// <summary>
    /// Vendor/manufacturer
    /// </summary>
    public virtual Guid? ShopProductVendorId { get; set; }
    public virtual ShopProductVendor? ShopProductVendor { get; set; }

    /// <summary>
    /// Product categories (many-to-many)
    /// </summary>
    public virtual ICollection<ShopProductCategory> ProductCategories { get; set; } = new List<ShopProductCategory>();

    /// <summary>
    /// Product photos
    /// </summary>
    public virtual ICollection<ShopProductPhoto> Photos { get; set; } = new List<ShopProductPhoto>();

    /// <summary>
    /// Product options (e.g., Size, Color)
    /// </summary>
    public virtual ICollection<ShopProductOption> Options { get; set; } = new List<ShopProductOption>();

    /// <summary>
    /// Product property values
    /// </summary>
    public virtual ICollection<ShopProductPropertyValue> PropertyValues { get; set; } = new List<ShopProductPropertyValue>();

    /// <summary>
    /// Order items for this product
    /// </summary>
    public virtual ICollection<ShopOrderItem> OrderItems { get; set; } = new List<ShopOrderItem>();

    /// <summary>
    /// Related products
    /// </summary>
    public virtual ICollection<ShopProduct> RelatedProducts { get; set; } = new List<ShopProduct>();

    /// <summary>
    /// Comments on this product
    /// </summary>
    public virtual ICollection<CmsComment> Comments { get; set; } = new List<CmsComment>();
}
