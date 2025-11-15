using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Cms;

/// <summary>
/// Photo gallery
/// </summary>
public class CmsPhotoGallery : CodedEntityBase, IEntityWithPublicStatus, IEntityWithOrder
{
    /// <summary>
    /// Gallery title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gallery description
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Cover image URL
    /// </summary>
    public virtual string? CoverImageUrl { get; set; }

    /// <summary>
    /// Indicates if gallery is publicly visible
    /// </summary>
    public virtual bool IsPublic { get; set; } = true;

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    // Navigation properties

    /// <summary>
    /// Photos in this gallery
    /// </summary>
    public virtual ICollection<CmsPhoto> Photos { get; set; } = new List<CmsPhoto>();

    /// <summary>
    /// Pages using this gallery
    /// </summary>
    public virtual ICollection<CmsPage> Pages { get; set; } = new List<CmsPage>();

    /// <summary>
    /// News items using this gallery
    /// </summary>
    public virtual ICollection<CmsNewsItem> NewsItems { get; set; } = new List<CmsNewsItem>();
}
