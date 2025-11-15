using Core.Domain.Common.Repositories;
using Core.Domain.Entities.Cms;

namespace Core.Domain.Repositories.Cms;

/// <summary>
/// Repository for CMS news items
/// </summary>
public interface ICmsNewsItemRepository : IRepository<CmsNewsItem>
{
    /// <summary>
    /// Get news item by code (slug)
    /// </summary>
    Task<CmsNewsItem?> GetByCodeAsync(string code, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get published news items
    /// </summary>
    Task<IEnumerable<CmsNewsItem>> GetPublishedAsync(int count, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get news items by category
    /// </summary>
    Task<IEnumerable<CmsNewsItem>> GetByCategoryAsync(Guid categoryId, CancellationToken cancellationToken = default);
}
