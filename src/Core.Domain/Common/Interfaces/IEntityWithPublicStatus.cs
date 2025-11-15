namespace Core.Domain.Common.Interfaces;

/// <summary>
/// Interface for entities that can be published/unpublished
/// </summary>
public interface IEntityWithPublicStatus : IEntity
{
    /// <summary>
    /// Indicates if entity is publicly visible
    /// </summary>
    bool IsPublic { get; set; }
}
