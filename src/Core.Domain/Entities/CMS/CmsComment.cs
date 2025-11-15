using Core.Domain.Common.Entities;

namespace Core.Domain.Entities.Cms;

/// <summary>
/// Comment on a page or news item
/// </summary>
public class CmsComment : EntityBase
{
    /// <summary>
    /// Comment author name
    /// </summary>
    public virtual string AuthorName { get; set; } = string.Empty;

    /// <summary>
    /// Comment author email
    /// </summary>
    public virtual string? AuthorEmail { get; set; }

    /// <summary>
    /// Comment text
    /// </summary>
    public virtual string Body { get; set; } = string.Empty;

    /// <summary>
    /// IP address of commenter
    /// </summary>
    public virtual string? IpAddress { get; set; }

    /// <summary>
    /// Is comment approved by moderator
    /// </summary>
    public virtual bool IsApproved { get; set; }

    // Navigation properties

    /// <summary>
    /// Page this comment belongs to
    /// </summary>
    public virtual Guid? CmsPageId { get; set; }
    public virtual CmsPage? CmsPage { get; set; }

    /// <summary>
    /// News item this comment belongs to
    /// </summary>
    public virtual Guid? CmsNewsItemId { get; set; }
    public virtual CmsNewsItem? CmsNewsItem { get; set; }

    /// <summary>
    /// Parent comment for threaded discussions
    /// </summary>
    public virtual Guid? ParentCommentId { get; set; }
    public virtual CmsComment? ParentComment { get; set; }

    /// <summary>
    /// Child comments (replies)
    /// </summary>
    public virtual ICollection<CmsComment> Replies { get; set; } = new List<CmsComment>();
}
