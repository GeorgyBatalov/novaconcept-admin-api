using Core.Domain.Common.Repositories;
using Core.Domain.Entities.Cms;

namespace Core.Domain.Repositories.Cms;

/// <summary>
/// Repository for CMS pages
/// </summary>
public interface ICmsPageRepository : IRepository<CmsPage>
{
    /// <summary>
    /// Get page by code (slug)
    /// </summary>
    Task<CmsPage?> GetByCodeAsync(string code, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get published pages
    /// </summary>
    Task<IEnumerable<CmsPage>> GetPublishedAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get pages by category
    /// </summary>
    Task<IEnumerable<CmsPage>> GetByCategoryAsync(Guid categoryId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get front page
    /// </summary>
    Task<CmsPage?> GetFrontPageAsync(CancellationToken cancellationToken = default);
}
