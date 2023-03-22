using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface IResumeTypeRepository<TContext> : IBaseRepository<ResumeType, TContext> where TContext : DbContext, new()
    {
    }
}
