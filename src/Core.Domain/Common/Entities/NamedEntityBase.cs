namespace Core.Domain.Common.Entities;

/// <summary>
/// Base class for entities with a name
/// </summary>
public abstract class NamedEntityBase : EntityBase
{
    /// <summary>
    /// Entity name
    /// </summary>
    public virtual string Name { get; set; } = string.Empty;

    public override string ToString()
    {
        return string.IsNullOrEmpty(Name) ? base.ToString() ?? string.Empty : Name;
    }
}
