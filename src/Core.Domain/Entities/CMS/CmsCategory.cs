using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Cms;

/// <summary>
/// CMS Category - for organizing pages and news items
/// </summary>
public class CmsCategory : CodedEntityBase, IEntityWithPublicStatus, IEntityWithOrder
{
    /// <summary>
    /// Category description
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Picture/thumbnail URL
    /// </summary>
    public virtual string? PictureUrl { get; set; }

    /// <summary>
    /// Indicates if category is publicly visible
    /// </summary>
    public virtual bool IsPublic { get; set; } = true;

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    // Navigation properties

    /// <summary>
    /// Parent category for hierarchical structure
    /// </summary>
    public virtual Guid? ParentCategoryId { get; set; }
    public virtual CmsCategory? ParentCategory { get; set; }

    /// <summary>
    /// Child categories
    /// </summary>
    public virtual ICollection<CmsCategory> ChildCategories { get; set; } = new List<CmsCategory>();

    /// <summary>
    /// Pages in this category
    /// </summary>
    public virtual ICollection<CmsPage> Pages { get; set; } = new List<CmsPage>();

    /// <summary>
    /// News items in this category
    /// </summary>
    public virtual ICollection<CmsNewsItem> NewsItems { get; set; } = new List<CmsNewsItem>();
}
