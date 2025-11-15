using Core.Domain.Common.Interfaces;

namespace Core.Domain.Common.Entities;

/// <summary>
/// Base class for all domain entities
/// </summary>
public abstract class EntityBase : IEntity
{
    /// <inheritdoc/>
    public virtual Guid Id { get; set; } = Guid.NewGuid();

    /// <inheritdoc/>
    public virtual int RowVersion { get; set; }

    /// <inheritdoc/>
    public virtual bool BuiltIn { get; set; }

    /// <inheritdoc/>
    public virtual DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    /// <inheritdoc/>
    public virtual DateTime? ModifiedDate { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is not EntityBase other)
            return false;

        if (ReferenceEquals(this, other))
            return true;

        if (GetType() != other.GetType())
            return false;

        if (Id == Guid.Empty || other.Id == Guid.Empty)
            return false;

        return Id == other.Id;
    }

    public override int GetHashCode()
    {
        return (GetType().ToString() + Id).GetHashCode();
    }

    public static bool operator ==(EntityBase? left, EntityBase? right)
    {
        if (left is null && right is null)
            return true;

        if (left is null || right is null)
            return false;

        return left.Equals(right);
    }

    public static bool operator !=(EntityBase? left, EntityBase? right)
    {
        return !(left == right);
    }
}
