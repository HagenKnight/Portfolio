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
    public class InterestService : CRUDService<InterestDTO, CommandDTO, int,
                              Interest, IInterestRepository<PortfolioDbContext>, PortfolioDbContext>,
                              IInterestService
    {

        public InterestService(IInterestRepository<PortfolioDbContext> repository,
            IUnitOfWork<PortfolioDbContext> unitOfWork,
            IMapper mapper,
            IDataShapeHelper<InterestDTO> dataShapeHelper
            ) : base(repository, unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<InterestDTO>> GetInterests(CancellationToken cancellationToken = default) =>
            await GetAllAsync(cancellationToken);

        public async Task<InterestDTO> FindInterest(int id, CancellationToken cancellationToken = default) =>
            await FindAsync(id, cancellationToken);

        public async Task<CreateInterestDTO> AddInterest(CreateInterestDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Name == objDTO.Name &&
                                  u.IsDeleted == false);
            if (ifExists.Count() > 0)
                throw new EntityAlreadyExistException(objDTO.GetType(), $"{objDTO.Name}");
            else
                return Mapper.Map<CreateInterestDTO>(await InsertAsync(objDTO, cancellationToken));
        }
        public async Task<UpdateInterestDTO> UpdateInterest(UpdateInterestDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExistsById = await GetSingleAsync(u => u.Id == objDTO.Id &&
                                    u.IsDeleted == false);
            if (ifExistsById == null)
                throw new EntityNotFoundException(objDTO.GetType(), objDTO.Id);
            else
            {
                var ifExistsByName = await GetSingleAsync(u => u.Name == objDTO.Name &&
                    u.IsDeleted == false,
                    null, cancellationToken);
                if (ifExistsByName != null)
                {
                    if (ifExistsByName.Id == objDTO.Id)
                        return Mapper.Map<UpdateInterestDTO>(await UpdateAsync(objDTO, cancellationToken));
                    else
                        throw new EntityDuplicatedException($"The Interest with '{objDTO.Name}' name  has already taken.");
                }
                else
                    return Mapper.Map<UpdateInterestDTO>(await UpdateAsync(objDTO, cancellationToken));
            }
        }
        public async Task<DeleteInterestDTO> DeleteInterest(DeleteInterestDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Id == objDTO.Id && u.IsDeleted == false);
            if (ifExists == null || ifExists.Count() == 0)
                if (ifExists == null || ifExists.Count() == 0)
                    throw new EntityNotFoundException(objDTO.Id.ToString());

            return Mapper.Map<DeleteInterestDTO>(await DeleteAsync(objDTO, autoSave, cancellationToken));
        }

    }
}
