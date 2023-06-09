﻿using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Core.Interfaces.Repository;
using Portfolio.Infrastructure.Persistence.Data;
using Portfolio.Infrastructure.Persistence.Repository.Base;

namespace Portfolio.Infrastructure.Common.Repositories
{
    public class AptitudeRepository : BaseRepository<Aptitude, int, PortfolioDbContext>, IAptitudeRepository<PortfolioDbContext>
    {
        public AptitudeRepository(IDbFactory<PortfolioDbContext> dbFactory) : base(dbFactory) { }
    }
}
