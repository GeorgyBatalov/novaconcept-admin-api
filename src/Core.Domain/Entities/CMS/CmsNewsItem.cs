using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Cms;

/// <summary>
/// CMS News Item - represents news/blog posts
/// </summary>
public class CmsNewsItem : CodedEntityBase, IEntityWithPublicStatus, IEntityWithOrder
{
    /// <summary>
    /// News title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Short description/excerpt
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Main content (HTML)
    /// </summary>
    public virtual string? Body { get; set; }

    /// <summary>
    /// Tags for categorization
    /// </summary>
    public virtual string? Tags { get; set; }

    /// <summary>
    /// SEO keywords
    /// </summary>
    public virtual string? Keywords { get; set; }

    /// <summary>
    /// Publication date
    /// </summary>
    public virtual DateTime IssueDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Picture/thumbnail URL
    /// </summary>
    public virtual string? PictureUrl { get; set; }

    /// <summary>
    /// Indicates if news item is publicly visible
    /// </summary>
    public virtual bool IsPublic { get; set; } = true;

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    /// <summary>
    /// Allow comments on this news item
    /// </summary>
    public virtual bool ShowComments { get; set; }

    // Navigation properties

    /// <summary>
    /// Category this news item belongs to
    /// </summary>
    public virtual Guid? CmsCategoryId { get; set; }
    public virtual CmsCategory? CmsCategory { get; set; }

    /// <summary>
    /// Photo gallery associated with this news item
    /// </summary>
    public virtual Guid? CmsPhotoGalleryId { get; set; }
    public virtual CmsPhotoGallery? CmsPhotoGallery { get; set; }

    /// <summary>
    /// Comments on this news item
    /// </summary>
    public virtual ICollection<CmsComment> Comments { get; set; } = new List<CmsComment>();
}
