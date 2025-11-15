using Core.Domain.Common.Entities;
using Core.Domain.Common.Interfaces;

namespace Core.Domain.Entities.Constructor;

/// <summary>
/// Property/question in a constructor step
/// </summary>
public class ConstructorStepProperty : CodedEntityBase, IEntityWithOrder
{
    /// <summary>
    /// Property title/question
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Property description/help text
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    /// <summary>
    /// Is this property required
    /// </summary>
    public virtual bool IsRequired { get; set; }

    // Navigation properties

    /// <summary>
    /// Step this property belongs to
    /// </summary>
    public virtual Guid ConstructorStepId { get; set; }
    public virtual ConstructorStep ConstructorStep { get; set; } = null!;

    /// <summary>
    /// Property type (e.g., Single Choice, Multiple Choice, Text)
    /// </summary>
    public virtual Guid? ConstructorStepPropertyTypeId { get; set; }
    public virtual ConstructorStepPropertyType? ConstructorStepPropertyType { get; set; }

    /// <summary>
    /// Property group (for organizing properties)
    /// </summary>
    public virtual Guid? ConstructorStepPropertyGroupId { get; set; }
    public virtual ConstructorStepPropertyGroup? ConstructorStepPropertyGroup { get; set; }

    /// <summary>
    /// Available values for this property
    /// </summary>
    public virtual ICollection<ConstructorStepPropertyAvailableValue> AvailableValues { get; set; } = new List<ConstructorStepPropertyAvailableValue>();

    /// <summary>
    /// Selected values in orders
    /// </summary>
    public virtual ICollection<ConstructorStepPropertyValue> SelectedValues { get; set; } = new List<ConstructorStepPropertyValue>();
}

/// <summary>
/// Property group for organizing properties
/// </summary>
public class ConstructorStepPropertyGroup : NamedEntityBase, IEntityWithOrder
{
    /// <summary>
    /// Group title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    // Navigation properties

    /// <summary>
    /// Properties in this group
    /// </summary>
    public virtual ICollection<ConstructorStepProperty> Properties { get; set; } = new List<ConstructorStepProperty>();
}

/// <summary>
/// Property type (Single Choice, Multiple Choice, Text, Number, etc.)
/// </summary>
public class ConstructorStepPropertyType : CodedEntityBase
{
    /// <summary>
    /// Type title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Type description
    /// </summary>
    public virtual string? Description { get; set; }

    // Navigation properties

    /// <summary>
    /// Properties of this type
    /// </summary>
    public virtual ICollection<ConstructorStepProperty> Properties { get; set; } = new List<ConstructorStepProperty>();
}

/// <summary>
/// Available value for a property (predefined choices)
/// </summary>
public class ConstructorStepPropertyAvailableValue : EntityBase, IEntityWithOrder
{
    /// <summary>
    /// Value title
    /// </summary>
    public virtual string Title { get; set; } = string.Empty;

    /// <summary>
    /// Value description
    /// </summary>
    public virtual string? Description { get; set; }

    /// <summary>
    /// Price modifier
    /// </summary>
    public virtual decimal? PriceModifier { get; set; }

    /// <summary>
    /// Image URL
    /// </summary>
    public virtual string? ImageUrl { get; set; }

    /// <summary>
    /// Order index for sorting
    /// </summary>
    public virtual int Order { get; set; }

    // Navigation properties

    /// <summary>
    /// Property this value belongs to
    /// </summary>
    public virtual Guid ConstructorStepPropertyId { get; set; }
    public virtual ConstructorStepProperty ConstructorStepProperty { get; set; } = null!;
}

/// <summary>
/// Selected value for a property in an order
/// </summary>
public class ConstructorStepPropertyValue : EntityBase
{
    /// <summary>
    /// Selected value (text or reference to available value)
    /// </summary>
    public virtual string? Value { get; set; }

    // Navigation properties

    /// <summary>
    /// Order this value belongs to
    /// </summary>
    public virtual Guid ConstructorOrderId { get; set; }
    public virtual ConstructorOrder ConstructorOrder { get; set; } = null!;

    /// <summary>
    /// Property this value is for
    /// </summary>
    public virtual Guid ConstructorStepPropertyId { get; set; }
    public virtual ConstructorStepProperty ConstructorStepProperty { get; set; } = null!;

    /// <summary>
    /// Selected available value (if applicable)
    /// </summary>
    public virtual Guid? ConstructorStepPropertyAvailableValueId { get; set; }
    public virtual ConstructorStepPropertyAvailableValue? ConstructorStepPropertyAvailableValue { get; set; }
}
