using AutoMapper;
using Portfolio.Core.DTO.Base;
using Portfolio.Core.DTO.ResumeType;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Repository;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Infrastructure.Persistence.Data;
using Portfolio.Infrastructure.Persistence.Services.Base;

namespace Portfolio.Infrastructure.Common.Services
{
    public class ResumeTypeService : CRUDService<ResumeTypeDTO, CommandDTO, int,
                                ResumeType, IResumeTypeRepository<PortfolioDbContext>, PortfolioDbContext>,
                                IResumeTypeService
    {
        public ResumeTypeService(IResumeTypeRepository<PortfolioDbContext> repository, 
            IUnitOfWork<PortfolioDbContext> unitOfWork, 
            IMapper mapper) 
            : base(repository, unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<ResumeTypeDTO>> GetResumeTypes(CancellationToken cancellationToken = default) =>
            await GetAllAsync(cancellationToken);
    }
}
