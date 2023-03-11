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
    public abstract class CRUDService<TQueryDTO, TCommandDTO, TKey, TEntity, TRepoAll, TContext> :
                         ICRUDService<TQueryDTO, TCommandDTO, TKey, TEntity, TRepoAll, TContext>
        where TEntity : class, IEntityBase<TKey>
        where TRepoAll : IBaseRepository<TEntity, TContext>
        where TContext : DbContext, new()
    {
        internal int _iCount;
        internal readonly IMapper _mapper;
        internal readonly TRepoAll _repository;
        internal readonly IUnitOfWork<TContext> _unitOfWork;

        public int RowCount => _iCount;
        protected IMapper Mapper => _mapper;
        protected TRepoAll Repository => _repository;
        protected IUnitOfWork<TContext> UnitOfWork => _unitOfWork;

        public CRUDService(TRepoAll repository, IUnitOfWork<TContext> unitOfWork, IMapper mapper)
        {
            _repository = Guard.Against.Null(repository, nameof(repository));
            _mapper = Guard.Against.Null(mapper, nameof(mapper));
            _unitOfWork = Guard.Against.Null(unitOfWork, nameof(unitOfWork));
        }


        public async Task<TQueryDTO> FindAsync(int id, CancellationToken cancellationToken = default)
        {
            TEntity getEntity = await _repository.GetByIdAsync(id, cancellationToken);

            if (getEntity != null)
            {
                if (!getEntity.IsDeleted)
                    return Mapper.Map<TQueryDTO>(getEntity);
                else
                    throw new EntityNotFoundException(typeof(TEntity), id);
            }
            else
                throw new EntityNotFoundException(typeof(TEntity), id);
        }

        public async Task<TQueryDTO> GetSingleAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            TEntity getEntity = await _repository.FilterSingleAsync(predicate, cancellationToken);

            if (getEntity != null)
                return Mapper.Map<TQueryDTO>(getEntity);
            else
                throw new EntityNotFoundException(typeof(TEntity));
        }

        public async Task<IEnumerable<TQueryDTO>> FilterAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default, string fields = null, string orderBy = null)
        {
            IEnumerable<TEntity> list = await _repository.FilterAsync(predicate, cancellationToken, orderBy);

            /* Limit query fields. */
            if (!string.IsNullOrWhiteSpace(fields))
                list = list.AsQueryable().Select<TEntity>($"new({fields})");

            return Mapper.Map<IEnumerable<TQueryDTO>>(list);
        }


        public async Task<IEnumerable<TQueryDTO>> GetAllAsync(CancellationToken cancellationToken = default, string fields = null, string orderBy = null)
        {
            IEnumerable<TEntity> list = await _repository.AllAsync(cancellationToken, orderBy);

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


        #region C.U.D operations

        public async Task<TQueryDTO> InsertAsync(TCommandDTO objDTO, CancellationToken cancellationToken = default)
        {
            try
            {
                TEntity addEntity = Mapper.Map<TEntity>(objDTO);
                addEntity.CreationDate = DateTime.UtcNow;
                await _repository.AddAsync(addEntity, cancellationToken);
                await _unitOfWork.CommitAsync(cancellationToken);
                return Mapper.Map<TQueryDTO>(addEntity);
            }
            catch (Exception ex)
            {

                throw new MappingNotFoundException(ex.Message, ex.InnerException);
            }

        }

        public async Task<TQueryDTO> UpdateAsync(TCommandDTO objDTO, CancellationToken cancellationToken = default)
        {
            try
            {
                TEntity updatedEntity = await _repository.GetByIdAsync(Convert.ToInt32(Mapper.Map<TEntity>(objDTO).Id), cancellationToken);

                if (updatedEntity == null)
                    throw new EntityNotFoundException(typeof(TEntity), Convert.ToInt32(Mapper.Map<TEntity>(objDTO).Id));

                Mapper.Map(objDTO, updatedEntity);
                updatedEntity.UpdateDate = DateTime.UtcNow;
                _repository.Update(updatedEntity);
                await _unitOfWork.CommitAsync(cancellationToken);
                return Mapper.Map<TQueryDTO>(updatedEntity);
            }
            catch (Exception ex)
            {
                throw new MappingNotFoundException(ex.Message, ex.InnerException);
            }
        }

        public async Task<TQueryDTO> DeleteAsync(TCommandDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            TEntity deletedEntity = await _repository.GetByIdAsync(Convert.ToInt32(Mapper.Map<TEntity>(objDTO).Id), cancellationToken);

            if (deletedEntity == null)
                throw new EntityNotFoundException(typeof(TEntity), Convert.ToInt32(Mapper.Map<TEntity>(objDTO).Id));

            if (autoSave)
            {
                Mapper.Map(objDTO, deletedEntity); deletedEntity.IsDeleted = true; deletedEntity.DeleteDate = DateTime.UtcNow;
                _repository.Update(deletedEntity);
            }
            else
                _repository.Delete(deletedEntity);

            await _unitOfWork.CommitAsync(cancellationToken);
            return Mapper.Map<TQueryDTO>(deletedEntity);
        }

        #endregion

    }
}
