using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface IInterestRepository<TContext> : IBaseRepository<Interest, TContext> where TContext : DbContext, new()
    {

    }
}
