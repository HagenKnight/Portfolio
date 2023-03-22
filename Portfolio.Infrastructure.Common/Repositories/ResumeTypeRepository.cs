using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Repository;
using Portfolio.Infrastructure.Persistence.Data;
using Portfolio.Infrastructure.Persistence.Repository.Base;

namespace Portfolio.Infrastructure.Common.Repositories
{
    public class ResumeTypeRepository : BaseRepository<ResumeType, int, PortfolioDbContext>, IResumeTypeRepository<PortfolioDbContext>
    {
        public ResumeTypeRepository(IDbFactory<PortfolioDbContext> dbFactory) : base(dbFactory)
        {
        }
    }
}
