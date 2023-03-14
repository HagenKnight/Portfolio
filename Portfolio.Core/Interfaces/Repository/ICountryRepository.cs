using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface ICountryRepository<TContext> : IBaseRepository<Country, TContext> where TContext : DbContext, new()
    {
        
    }
}
