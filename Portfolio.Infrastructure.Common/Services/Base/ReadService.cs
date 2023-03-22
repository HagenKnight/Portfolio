using Ardalis.GuardClauses;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Exceptions;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Management;
using Portfolio.Core.Interfaces.Services.Base;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace Portfolio.Infrastructure.Persistence.Services.Base
{
    public abstract class ReadService<TQueryDTO, TKey, TEntity, TRepoRead, TContext> :
      IReadService<TQueryDTO, TKey, TEntity, TRepoRead, TContext>
      where TEntity : class, IEntityBase<TKey>
      where TRepoRead : IReadRepository<TEntity, TContext>
      where TContext : DbContext, new()
    {
        internal int _iCount;
        internal readonly IMapper _mapper;
        internal readonly TRepoRead _repository;
        internal readonly IUnitOfWork<TContext> _unitOfWork;

        public int RowCount => _iCount;


        protected IMapper Mapper => _mapper;
        protected TRepoRead Repository => _repository;
        protected IUnitOfWork<TContext> UnitOfWork => _unitOfWork;

        public ReadService(IMapper mapper, IUnitOfWork<TContext> unitOfWork, TRepoRead repository)
        {
            _unitOfWork = Guard.Against.Null(unitOfWork, nameof(unitOfWork));
            _repository = Guard.Against.Null(repository, nameof(repository));
            _mapper = Guard.Against.Null(mapper, nameof(mapper));
        }

        public async Task<TQueryDTO> FindAsync(int id, CancellationToken cancellationToken = default)
        {
            TEntity getEntity = await _repository.GetByIdAsync(id, cancellationToken);

            if (getEntity != null)
                return _mapper.Map<TQueryDTO>(getEntity);
            else
                throw new EntityNotFoundException(typeof(TEntity), id);
        }

        public async Task<TQueryDTO> GetSingleAsync(Expression<Func<TEntity, bool>> predicate, string entityToInclude = null, CancellationToken cancellationToken = default)
        {
            TEntity getEntity = await _repository.FilterSingleAsync(predicate, entityToInclude, cancellationToken);

            if (getEntity != null)
                return _mapper.Map<TQueryDTO>(getEntity);
            else
                throw new EntityNotFoundException(typeof(TEntity));
        }

        public async Task<IEnumerable<TQueryDTO>> FilterAsync(Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default,
            string entityToInclude = null,
            string fields = null, string orderBy = null)
        {
            IEnumerable<TEntity> list = await _repository.FilterAsync(predicate, cancellationToken, entityToInclude, orderBy);

            /* Limit query fields. */
            if (!string.IsNullOrWhiteSpace(fields))
                list = list.AsQueryable().Select<TEntity>($"new({fields})");

            return Mapper.Map<IEnumerable<TQueryDTO>>(list);
        }

        public async Task<IEnumerable<TQueryDTO>> GetAllAsync(CancellationToken cancellationToken = default, string fields = null, string orderBy = null)
        {
            IEnumerable<TEntity> list = await _repository.AllAsync(orderBy, cancellationToken);

            /* Limit query fields. */
            if (!string.IsNullOrWhiteSpace(fields))
                list = list.AsQueryable().Select<TEntity>($"new({fields})");

            return Mapper.Map<IEnumerable<TQueryDTO>>(list);
        }

        public async Task<IEnumerable<TQueryDTO>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default, string fields = null, string orderBy = null)
        {
            IEnumerable<TEntity> list = await _repository.AllAsync(predicate, cancellationToken, orderBy);

            /* Limit query fields. */
            if (!string.IsNullOrWhiteSpace(fields))
                list = list.AsQueryable().Select<TEntity>($"new({fields})");

            return Mapper.Map<IEnumerable<TQueryDTO>>(list);
        }

        public async Task<IEnumerable<TQueryDTO>> GetAllIncludeAsync(string entityToInclude = null, CancellationToken cancellationToken = default)
        {
            IEnumerable<TEntity> list = await _repository.AllAsync(entityToInclude, cancellationToken);
            return Mapper.Map<IEnumerable<TQueryDTO>>(list);
        }

        public async Task<IEnumerable<TQueryDTO>> GetAllIncludeAsync(Expression<Func<TEntity, bool>> predicate, string entityToInclude = null, CancellationToken cancellationToken = default, string fields = null, string orderBy = null)
        {
            IEnumerable<TEntity> list = await _repository.AllAsync(predicate, entityToInclude, cancellationToken, orderBy);

            /* Limit query fields. */
            if (!string.IsNullOrWhiteSpace(fields))
                list = list.AsQueryable().Select<TEntity>($"new({fields})");

            return Mapper.Map<IEnumerable<TQueryDTO>>(list);
        }

        public async Task<IEnumerable<TQueryDTO>> GetPagedAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default, string fields = null, string orderBy = null)
        {
            _iCount = _repository.GetCount();

            if (pageNumber < 1 || (pageNumber > ((int)Math.Ceiling(_iCount / (double)pageSize))))
                throw new PageRowIndexNotFound(pageNumber);

            if (pageSize < 10)
                throw new PageRowMinimumException(pageSize);

            if (pageSize > 50)
                throw new PageRowMaximumException(pageSize);

            IEnumerable<TEntity> list = await _repository.GetPagedAsync(pageNumber, pageSize, cancellationToken, orderBy);

            /* Limit query fields. */
            if (!string.IsNullOrWhiteSpace(fields))
                list = list.AsQueryable().Select<TEntity>($"new({fields})");

            return Mapper.Map<IEnumerable<TQueryDTO>>(list);
        }

        public async Task<IEnumerable<TQueryDTO>> GetPagedAsync(int pageNumber, int pageSize, Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default, string fields = null, string orderBy = null)
        {
            _iCount = _repository.GetCount(predicate);

            if (pageNumber < 1 || (pageNumber > ((int)Math.Ceiling(_iCount / (double)pageSize))))
                throw new PageRowIndexNotFound(pageNumber);

            if (pageSize < 10)
                throw new PageRowMinimumException(pageSize);

            if (pageSize > 50)
                throw new PageRowMaximumException(pageSize);

            IEnumerable<TEntity> list = await _repository.GetPagedAsync(pageNumber, pageSize, predicate, cancellationToken, orderBy);

            /* Limit query fields. */
            if (!string.IsNullOrWhiteSpace(fields))
                list = list.AsQueryable().Select<TEntity>($"new({fields})");

            return Mapper.Map<IEnumerable<TQueryDTO>>(list);
        }


    }
}
