using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Constructor;

/// <summary>
/// Constructor step in configuration wizard
/// </summary>
public class ConstructorStep : CodedEntityBase, IEntityWithPublicStatus, IEntityWithOrder
{
    /// <summary>
    /// Step title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Step description
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Indicates if step is publicly visible
    /// </summary>
    public virtual bool IsPublic { get; set; } = true;

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    /// <summary>
    /// Is this step required
    /// </summary>
    public virtual bool IsRequired { get; set; } = true;

    // Navigation properties

    /// <summary>
    /// Properties in this step
    /// </summary>
    public virtual ICollection<ConstructorStepProperty> Properties { get; set; } = new List<ConstructorStepProperty>();
}
