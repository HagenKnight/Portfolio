using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Management;

namespace Portfolio.Core.Interfaces.Services.Base
{
    public interface ICRUDService<TQueryDTO, TCommandDTO, TKey, TEntity, TRepoAll, TContext> :
        IReadService<TQueryDTO, TKey, TEntity, TRepoAll, TContext>
     where TEntity : class, IEntityBase<TKey>
     where TRepoAll : IBaseRepository<TEntity, TContext>
     where TContext : DbContext, new()
    {
        Task<TQueryDTO> UpdateAsync(TCommandDTO objDTO, CancellationToken cancellationToken = default);
        Task<TQueryDTO> InsertAsync(TCommandDTO objDTO, CancellationToken cancellationToken = default);
        Task<TQueryDTO> DeleteAsync(TCommandDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default);
    }
}
