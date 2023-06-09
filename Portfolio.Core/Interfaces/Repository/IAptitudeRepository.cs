using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface IAptitudeRepository<TContext> : IBaseRepository<Aptitude, TContext> where TContext : DbContext, new()
    {

    }
}
