using AutoMapper;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.DTO.Resume;
using Portfolio.Core.DTO.WorkerProfile;
using Portfolio.Core.Entities;
using Portfolio.Core.Exceptions;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Repository;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Infrastructure.Persistence.Data;
using Portfolio.Infrastructure.Persistence.Services.Base;

namespace Portfolio.Infrastructure.Common.Services
{
    public class ResumeService : CRUDService<ResumeDTO, CommandDTO, int,
                                Resume, IResumeRepository<PortfolioDbContext>, PortfolioDbContext>,
                                IResumeService
    {
        public ResumeService(IResumeRepository<PortfolioDbContext> repository,
            IUnitOfWork<PortfolioDbContext> unitOfWork,
            IMapper mapper) : base(repository, unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<ResumeDTO>> GetResumes(int workerProfileId, CancellationToken cancellationToken = default) =>
            await FilterAsync(u => u.WorkerProfileId == workerProfileId, cancellationToken, "ResumeType", null, "ResumeTypeId");

        public Task<ResumeDTO> FindResume(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<ResumeDTO> FindResume(string email, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        public async Task<CreateResumeDTO> AddResume(CreateResumeDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Title == objDTO.Title &&
                                 u.InstitutionName == objDTO.InstitutionName &&
                                 u.StartDate.Date == objDTO.StartDate.Date &&
                                 u.FinishDate.Date == objDTO.FinishDate.Date &&
                                 u.IsDeleted == false);
            if (ifExists.Count() > 0)
                throw new EntityAlreadyExistException(objDTO.GetType(), $"{objDTO.InstitutionName}");
            else
                return Mapper.Map<CreateResumeDTO>(await InsertAsync(objDTO, cancellationToken));
        }

        public async Task<UpdateResumeDTO> UpdateResume(UpdateResumeDTO objDTO, CancellationToken cancellationToken = default)
        {
            var ifExists = await GetSingleAsync(u => u.Title == objDTO.Title &&
                                 u.InstitutionName == objDTO.InstitutionName &&
                                 u.IsDeleted == false);
            if (ifExists == null)
                throw new EntityNotFoundException(objDTO.GetType(), $"{objDTO.InstitutionName}");
            else
                return Mapper.Map<UpdateResumeDTO>(await UpdateAsync(objDTO, cancellationToken));
        }

        public async Task<DeleteResumeDTO> DeleteResume(DeleteResumeDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default)
        {
            var ifExists = await FilterAsync(u => u.Id == objDTO.Id && u.IsDeleted == false);
            if (ifExists == null || ifExists.Count() == 0)
                if (ifExists == null || ifExists.Count() == 0)
                    throw new EntityNotFoundException(objDTO.Id.ToString());

            return Mapper.Map<DeleteResumeDTO>(await DeleteAsync(objDTO, autoSave, cancellationToken));
        }
    }
}
