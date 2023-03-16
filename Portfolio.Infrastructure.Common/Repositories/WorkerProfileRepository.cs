using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Repository;
using Portfolio.Infrastructure.Persistence.Data;
using Portfolio.Infrastructure.Persistence.Repository.Base;

namespace Portfolio.Infrastructure.Common.Repositories
{
    public class WorkerProfileRepository : BaseRepository<WorkerProfile, int, PortfolioDbContext>, IWorkerProfileRepository<PortfolioDbContext>
    {
        public WorkerProfileRepository(IDbFactory<PortfolioDbContext> dbFactory) : base(dbFactory)
        {
        }
    }
}
