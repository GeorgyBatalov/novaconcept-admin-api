namespace Core.Domain.Common.Entities;

/// <summary>
/// Base class for entities with a code (slug/URL-friendly identifier)
/// </summary>
public abstract class CodedEntityBase : NamedEntityBase
{
    /// <summary>
    /// Unique code/slug for URL-friendly access
    /// </summary>
    public virtual string Code { get; set; } = string.Empty;
}
