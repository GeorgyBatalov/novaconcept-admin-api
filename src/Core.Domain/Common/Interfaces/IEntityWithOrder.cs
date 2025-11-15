namespace Core.Domain.Common.Interfaces;

/// <summary>
/// Interface for entities that have custom ordering
/// </summary>
public interface IEntityWithOrder : IEntity
{
    /// <summary>
    /// Order index for sorting
    /// </summary>
    int Order { get; set; }
}
