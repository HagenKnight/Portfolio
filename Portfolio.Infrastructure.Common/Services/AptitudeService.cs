using AutoMapper;
using Portfolio.Core.DTO;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.Entities;
using Portfolio.Core.Exceptions;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Management;
using Portfolio.Core.Interfaces.Repository;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Infrastructure.Persistence.Data;
using Portfolio.Infrastructure.Persistence.Services.Base;

namespace Portfolio.Infrastructure.Common.Services
{
    public class AptitudeService : CRUDService<AptitudeDTO, CommandDTO, int,
                                Aptitude, IAptitudeRepository<PortfolioDbContext>, PortfolioDbContext>,
                                IAptitudeService
    {
        public AptitudeService(IAptitudeRepository<PortfolioDbContext> repository,
            IUnitOfWork<PortfolioDbContext> unitOfWork,
            IMapper mapper,
            IDataShapeHelper<AptitudeDTO> dataShapeHelper
            ) : base(repository, unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<AptitudeDTO>> GetAptitudes(CancellationToken cancellationToken = default) =>
            await GetAllAsync(cancellationToken);

        public async Task<AptitudeDTO> FindAptitude(int id, CancellationToken cancellationToken = default) =>
            await FindAsync(id, cancellationToken);

        public async Task<CreateAptitudeDTO> AddAptitude(CreateAptitudeDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Name == objDTO.Name &&
                                  u.IsDeleted == false);
            if (ifExists.Count() > 0)
                throw new EntityAlreadyExistException(objDTO.GetType(), $"{objDTO.Name}");
            else
                return Mapper.Map<CreateAptitudeDTO>(await InsertAsync(objDTO, cancellationToken));
        }
        public async Task<UpdateAptitudeDTO> UpdateAptitude(UpdateAptitudeDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await GetSingleAsync(u => u.Id == objDTO.Id && u.IsDeleted == false);
            if (ifExists == null)
                throw new EntityNotFoundException(objDTO.GetType(), objDTO.Id);
            else
            {
                ifExists = await GetSingleAsync(u => u.Name == objDTO.Name && u.IsDeleted == false);
                if (ifExists != null)
                {
                    if (ifExists.Id == objDTO.Id)
                    {
                        return Mapper.Map<UpdateAptitudeDTO>(await UpdateAsync(objDTO, cancellationToken));
                    }
                    else
                        throw new EntityDuplicatedException($"The aptitude with '{objDTO.Name}' name  has already taken.");
                }
                else
                {
                    ifExists = await GetSingleAsync(u => u.Name == objDTO.Name &&
                                                    u.Id == objDTO.Id &&
                                                    u.IsDeleted == false);
                    return Mapper.Map<UpdateAptitudeDTO>(await UpdateAsync(objDTO, cancellationToken));
                }
            }
        }
        public async Task<DeleteAptitudeDTO> DeleteAptitude(DeleteAptitudeDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Id == objDTO.Id && u.IsDeleted == false);
            if (ifExists == null || ifExists.Count() == 0)
                if (ifExists == null || ifExists.Count() == 0)
                    throw new EntityNotFoundException(objDTO.Id.ToString());

            return Mapper.Map<DeleteAptitudeDTO>(await DeleteAsync(objDTO, autoSave, cancellationToken));
        }

    }

}
