using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Cms;

/// <summary>
/// CMS Page entity - represents content pages on the website
/// </summary>
public class CmsPage : CodedEntityBase, IEntityWithPublicStatus, IEntityWithOrder
{
    /// <summary>
    /// Page title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Short description/excerpt
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Main page content (HTML)
    /// </summary>
    public virtual string? Body { get; set; }

    /// <summary>
    /// Tags for categorization and search
    /// </summary>
    public virtual string? Tags { get; set; }

    /// <summary>
    /// Master page template to use
    /// </summary>
    public virtual string? MasterPage { get; set; }

    /// <summary>
    /// SEO keywords
    /// </summary>
    public virtual string? Keywords { get; set; }

    /// <summary>
    /// Show breadcrumbs navigation
    /// </summary>
    public virtual bool ShowBreadcrumbs { get; set; } = true;

    /// <summary>
    /// Allow comments on this page
    /// </summary>
    public virtual bool ShowComments { get; set; }

    /// <summary>
    /// Use this page as front page (homepage)
    /// </summary>
    public virtual bool IsFrontPage { get; set; }

    /// <summary>
    /// Publication date
    /// </summary>
    public virtual DateTime IssueDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Indicates if page is publicly visible
    /// </summary>
    public virtual bool IsPublic { get; set; } = true;

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    /// <summary>
    /// Picture/thumbnail URL
    /// </summary>
    public virtual string? PictureUrl { get; set; }

    // Navigation properties

    /// <summary>
    /// Category this page belongs to
    /// </summary>
    public virtual Guid? CmsCategoryId { get; set; }
    public virtual CmsCategory? CmsCategory { get; set; }

    /// <summary>
    /// Photo gallery associated with this page
    /// </summary>
    public virtual Guid? CmsPhotoGalleryId { get; set; }
    public virtual CmsPhotoGallery? CmsPhotoGallery { get; set; }

    /// <summary>
    /// Comments on this page
    /// </summary>
    public virtual ICollection<CmsComment> Comments { get; set; } = new List<CmsComment>();

    /// <summary>
    /// Menu items that link to this page
    /// </summary>
    public virtual ICollection<CmsMenuItem> MenuItems { get; set; } = new List<CmsMenuItem>();
}
