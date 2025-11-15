using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Cms;

/// <summary>
/// Menu item for site navigation
/// </summary>
public class CmsMenuItem : NamedEntityBase, IEntityWithPublicStatus, IEntityWithOrder
{
    /// <summary>
    /// Menu item title/text
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Link URL
    /// </summary>
    public virtual string? Url { get; set; }

    /// <summary>
    /// CSS class for styling
    /// </summary>
    public virtual string? CssClass { get; set; }

    /// <summary>
    /// Icon CSS class (e.g., Font Awesome)
    /// </summary>
    public virtual string? IconClass { get; set; }

    /// <summary>
    /// Open link in new window
    /// </summary>
    public virtual bool OpenInNewWindow { get; set; }

    /// <summary>
    /// Indicates if menu item is publicly visible
    /// </summary>
    public virtual bool IsPublic { get; set; } = true;

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    // Navigation properties

    /// <summary>
    /// Menu this item belongs to
    /// </summary>
    public virtual Guid? CmsMenuId { get; set; }
    public virtual CmsMenu? CmsMenu { get; set; }

    /// <summary>
    /// Page this menu item links to
    /// </summary>
    public virtual Guid? CmsPageId { get; set; }
    public virtual CmsPage? CmsPage { get; set; }

    /// <summary>
    /// Parent menu item for hierarchical menus
    /// </summary>
    public virtual Guid? ParentMenuItemId { get; set; }
    public virtual CmsMenuItem? ParentMenuItem { get; set; }

    /// <summary>
    /// Child menu items
    /// </summary>
    public virtual ICollection<CmsMenuItem> ChildMenuItems { get; set; } = new List<CmsMenuItem>();
}
