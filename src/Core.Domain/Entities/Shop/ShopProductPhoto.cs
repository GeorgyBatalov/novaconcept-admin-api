using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Shop;

/// <summary>
/// Product photo
/// </summary>
public class ShopProductPhoto : EntityBase, IEntityWithOrder
{
    /// <summary>
    /// Photo title
    /// </summary>
    public virtual string? Title { get; set; }

    /// <summary>
    /// Photo description
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Image file URL
    /// </summary>
    public virtual string ImageUrl { get; set; } = string.Empty;

    /// <summary>
    /// Thumbnail URL
    /// </summary>
    public virtual string? ThumbnailUrl { get; set; }

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    // Navigation properties

    /// <summary>
    /// Product this photo belongs to
    /// </summary>
    public virtual Guid ShopProductId { get; set; }
    public virtual ShopProduct ShopProduct { get; set; } = null!;
}
