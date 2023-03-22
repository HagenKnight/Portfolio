using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface IResumeRepository<TContext> : IBaseRepository<Resume, TContext> where TContext : DbContext, new()
    {
    }
}
