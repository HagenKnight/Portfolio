using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Repository;
using Portfolio.Infrastructure.Persistence.Data;
using Portfolio.Infrastructure.Persistence.Repository.Base;

namespace Portfolio.Infrastructure.Common.Repositories
{
    public class EntityRepository
        : BaseRepository<Entity, int, PortfolioDbContext>, IEntityRepository<PortfolioDbContext>
    {
        private readonly PortfolioDbContext _portfolioDbContext;
        public EntityRepository(IDbFactory<PortfolioDbContext> dbFactory) : base(dbFactory) { }


    }
}
