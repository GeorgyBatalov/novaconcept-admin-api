using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Cms;

/// <summary>
/// Photo in a gallery
/// </summary>
public class CmsPhoto : EntityBase, IEntityWithOrder
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
    /// Gallery this photo belongs to
    /// </summary>
    public virtual Guid CmsPhotoGalleryId { get; set; }
    public virtual CmsPhotoGallery CmsPhotoGallery { get; set; } = null!;
}
