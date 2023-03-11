using Microsoft.EntityFrameworkCore;

namespace Portfolio.Core.Interfaces.Base
{
    public interface IDbFactory<TContext> : IDisposable where TContext : DbContext, new()
    {
        TContext Init();
    }
}
