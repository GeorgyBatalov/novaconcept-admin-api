using Core.Domain.Common.Entities;

namespace Core.Domain.Entities.Cms;

/// <summary>
/// Menu container (e.g., Main Menu, Footer Menu)
/// </summary>
public class CmsMenu : CodedEntityBase
{
    /// <summary>
    /// Menu title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Menu description
    /// </summary>
    public virtual string? Description { get; set; }

    // Navigation properties

    /// <summary>
    /// Menu items in this menu
    /// </summary>
    public virtual ICollection<CmsMenuItem> MenuItems { get; set; } = new List<CmsMenuItem>();
}
