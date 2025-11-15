using Core.Domain.Common.Entities;

namespace Core.Domain.Entities.Constructor;

/// <summary>
/// Constructor order - customer configuration built through step-by-step wizard
/// </summary>
public class ConstructorOrder : EntityBase
{
    /// <summary>
    /// Order number (human-readable)
    /// </summary>
    public virtual string OrderNumber { get; set; } = string.Empty;

    /// <summary>
    /// Order date
    /// </summary>
    public virtual DateTime OrderDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Customer name
    /// </summary>
    public virtual string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Customer email
    /// </summary>
    public virtual string? CustomerEmail { get; set; }

    /// <summary>
    /// Customer phone
    /// </summary>
    public virtual string? CustomerPhone { get; set; }

    /// <summary>
    /// Order comment/notes
    /// </summary>
    public virtual string? Comment { get; set; }

    /// <summary>
    /// Total calculated price
    /// </summary>
    public virtual decimal? TotalPrice { get; set; }

    /// <summary>
    /// IP address of customer
    /// </summary>
    public virtual string? IpAddress { get; set; }

    /// <summary>
    /// Order status
    /// </summary>
    public virtual string Status { get; set; } = "New";

    // Navigation properties

    /// <summary>
    /// Selected values for each step
    /// </summary>
    public virtual ICollection<ConstructorStepPropertyValue> SelectedValues { get; set; } = new List<ConstructorStepPropertyValue>();
}
