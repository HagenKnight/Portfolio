using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface IAptitudeOnResumeRepository<TContext> : IBaseRepository<AptitudeOnResume, TContext> where TContext : DbContext, new()
    {

    }
}
