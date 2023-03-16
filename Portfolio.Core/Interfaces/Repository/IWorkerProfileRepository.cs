using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Core.Interfaces.Repository
{
    public interface IWorkerProfileRepository<TContext> : IBaseRepository<WorkerProfile, TContext> where TContext : DbContext, new()
    {

    }
}
