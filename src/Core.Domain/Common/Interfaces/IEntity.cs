namespace Core.Domain.Common.Interfaces;

/// <summary>
/// Base interface for all entities
/// </summary>
public interface IEntity
{
    /// <summary>
    /// Unique identifier
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Row version for concurrency control
    /// </summary>
    int RowVersion { get; set; }

    /// <summary>
    /// Indicates if this is a built-in system entity (read-only)
    /// </summary>
    bool BuiltIn { get; set; }

    /// <summary>
    /// Date when entity was created
    /// </summary>
    DateTime CreatedDate { get; set; }

    /// <summary>
    /// Date when entity was last modified
    /// </summary>
    DateTime? ModifiedDate { get; set; }
}
