using AutoMapper;
using Portfolio.Core.DTO;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Repository;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Infrastructure.Persistence.Data;
using Portfolio.Infrastructure.Persistence.Services.Base;

namespace Portfolio.Infrastructure.Common.Services
{
    public class EntityService : CRUDService<EntityDTO, CommandDTO, int,
                                Entity, IEntityRepository<PortfolioDbContext>, PortfolioDbContext>,
                                IEntityService
    {
        public EntityService(IEntityRepository<PortfolioDbContext> repository,
          IUnitOfWork<PortfolioDbContext> unitOfWork,
          IMapper mapper) : base(repository,
                                 unitOfWork,
                                 mapper)
        {

        }


        public Task<CreateEntityDTO> AddEntity(CreateEntityDTO objDTO, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteEntityDTO> DeleteEntity(DeleteEntityDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<EntityDTO> FindEntity(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EntityDTO>> GetEntities(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateEntityDTO> UpdateEntity(UpdateEntityDTO objDTO, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
