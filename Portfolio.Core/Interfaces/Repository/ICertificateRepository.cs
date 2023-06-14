using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface ICertificateRepository<TContext> : IBaseRepository<Certificate, TContext> where TContext : DbContext, new()
    {

    }

}
