using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Shop;

/// <summary>
/// Shop product category (many-to-many join entity)
/// </summary>
public class ShopProductCategory : EntityBase, IEntityWithOrder
{
    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    // Navigation properties

    /// <summary>
    /// Product
    /// </summary>
    public virtual Guid ShopProductId { get; set; }
    public virtual ShopProduct ShopProduct { get; set; } = null!;

    /// <summary>
    /// Category
    /// </summary>
    public virtual Guid CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;
}

/// <summary>
/// Product category
/// </summary>
public class Category : CodedEntityBase, IEntityWithPublicStatus, IEntityWithOrder
{
    /// <summary>
    /// Category title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Category description
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Picture URL
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
    public virtual Category? ParentCategory { get; set; }

    /// <summary>
    /// Child categories
    /// </summary>
    public virtual ICollection<Category> ChildCategories { get; set; } = new List<Category>();

    /// <summary>
    /// Products in this category (many-to-many)
    /// </summary>
    public virtual ICollection<ShopProductCategory> ProductCategories { get; set; } = new List<ShopProductCategory>();
}
