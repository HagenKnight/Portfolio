using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface IProjectRepository<TContext> : IBaseRepository<Project, TContext> where TContext : DbContext, new()
    {

    }

}
