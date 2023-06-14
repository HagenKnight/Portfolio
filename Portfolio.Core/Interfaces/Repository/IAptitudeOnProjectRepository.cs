using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface IAptitudeOnProjectRepository<TContext> : IBaseRepository<AptitudeOnProject, TContext> where TContext : DbContext, new()
    {

    }
}
