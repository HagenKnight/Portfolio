using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Management;
using System.Linq.Expressions;

namespace Portfolio.Core.Interfaces.Services.Base
{
    public interface IReadService<TQueryDTO, TKey, TEntity, TRepoRead, TContext>
        where TEntity : class, IEntityBase<TKey>
        where TRepoRead : IReadRepository<TEntity, TContext>
        where TContext : DbContext, new()
    {
        Task<TQueryDTO> FindAsync(int id, CancellationToken cancellationToken = default);
        Task<TQueryDTO> GetSingleAsync(Expression<Func<TEntity, bool>> predicate, string entityToInclude = null, CancellationToken cancellationToken = default);

        Task<IEnumerable<TQueryDTO>> FilterAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default, string entityToInclude = null, string fields = null, string orderBy = null);
        
        Task<IEnumerable<TQueryDTO>> GetAllAsync(CancellationToken cancellationToken = default, string fields = null, string orderBy = null);
        Task<IEnumerable<TQueryDTO>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default, string fields = null, string orderBy = null);
        
        Task<IEnumerable<TQueryDTO>> GetAllIncludeAsync(string entityToInclude = null, CancellationToken cancellationToken = default);
        Task<IEnumerable<TQueryDTO>> GetAllIncludeAsync(Expression<Func<TEntity, bool>> predicate, string entityToInclude = null, CancellationToken cancellationToken = default, string fields = null, string orderBy = null);



        Task<IEnumerable<TQueryDTO>> GetPagedAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default, string fields = null, string orderBy = null);
        Task<IEnumerable<TQueryDTO>> GetPagedAsync(int pageNumber, int pageSize, Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default, string fields = null, string orderBy = null);
    }
}
