using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;
using System.Linq.Expressions;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface IEntityRepository<TContext> : IBaseRepository<Entity, TContext> where TContext : DbContext, new()
    {
        public Task<IEnumerable<Entity>> AllAsync(CancellationToken cancellationToken = default, string orderBy = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entity>> AllAsync(Expression<Func<Entity, bool>> predicate, CancellationToken cancellationToken = default, string orderBy = null)
        {
            throw new NotImplementedException();
        }

        public Task<Entity> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entity>> FilterAsync(Expression<Func<Entity, bool>> predicate, CancellationToken cancellationToken = default, string orderBy = null)
        {
            throw new NotImplementedException();
        }

        public Task<Entity> FilterSingleAsync(Expression<Func<Entity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<Entity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<Entity> EntityList, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entity>> GetPagedAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default, string orderBy = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entity>> GetPagedAsync(int pageNumber, int pageSize, Expression<Func<Entity, bool>> predicate, CancellationToken cancellationToken = default, string orderBy = null)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Entity Entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        public void Update(Entity Entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(Entity entity)
        {
            throw new NotImplementedException();
        }

    }
}
