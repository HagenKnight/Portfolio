using AutoMapper;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.DTO.WorkerProfile;
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
    public class WorkerProfileService : CRUDService<WorkerProfileDTO, CommandDTO, int,
                                WorkerProfile, IWorkerProfileRepository<PortfolioDbContext>, PortfolioDbContext>,
                                IWorkerProfileService
    {

        public WorkerProfileService(IWorkerProfileRepository<PortfolioDbContext> repository,
            IUnitOfWork<PortfolioDbContext> unitOfWork,
            IMapper mapper,
            IDataShapeHelper<WorkerProfileDTO> dataShapeHelper
            ) : base(repository, unitOfWork, mapper)
        {
        }


        public async Task<WorkerProfileDTO> FindWorkerProfile(int id, CancellationToken cancellationToken = default) =>
            await FindAsync(id, cancellationToken);

        public async Task<IEnumerable<WorkerProfileDTO>> GetWorkerProfiles(CancellationToken cancellationToken = default) =>
            await GetAllAsync(cancellationToken);

        public async Task<CreateWorkerProfileDTO> AddWorkerProfile(CreateWorkerProfileDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.FirstName == objDTO.FirstName &&
                                 u.LastName == objDTO.LastName &&
                                 u.IsDeleted == false);
            if (ifExists.Count() > 0)
                throw new EntityAlreadyExistException(objDTO.GetType(), $"{objDTO.FirstName} {objDTO.LastName}");
            else
                return Mapper.Map<CreateWorkerProfileDTO>(await InsertAsync(objDTO, cancellationToken));

        }

        public async Task<UpdateWorkerProfileDTO> UpdateWorkerProfile(UpdateWorkerProfileDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await GetSingleAsync(u => u.FirstName == objDTO.FirstName &&
                                 u.LastName == objDTO.LastName &&
                                 u.IsDeleted == false);
            if (ifExists == null)
                throw new EntityNotFoundException(objDTO.GetType(), $"{objDTO.FirstName} {objDTO.LastName}");
            else
                return Mapper.Map<UpdateWorkerProfileDTO>(await UpdateAsync(objDTO, cancellationToken));
        }

        public async Task<DeleteWorkerProfileDTO> DeleteWorkerProfile(DeleteWorkerProfileDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Id == objDTO.Id && u.IsDeleted == false);
            if (ifExists == null || ifExists.Count() == 0)
            if (ifExists == null || ifExists.Count() == 0)
                throw new EntityNotFoundException(objDTO.Id.ToString());

            return Mapper.Map<DeleteWorkerProfileDTO>(await DeleteAsync(objDTO, autoSave, cancellationToken));
        }
    }
}
