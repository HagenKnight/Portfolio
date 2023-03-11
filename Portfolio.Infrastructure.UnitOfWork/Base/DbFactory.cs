using Microsoft.EntityFrameworkCore;
using Portfolio.Core.Interfaces.Base;

namespace Portfolio.Infrastructure.UnitOfWork.Base
{
    public class DbFactory<TContext> : IDisposable, IDbFactory<TContext>
        where TContext : DbContext, new()

    {
        private bool _disposed;
        private TContext _dbContext;
        private Func<TContext> _instanceFunc;

        public DbFactory(Func<TContext> dbContextFactory)
        {
            _instanceFunc = dbContextFactory;
        }
        public void Dispose()
        {
            if (!_disposed && _dbContext != null)
            {
                _disposed = true;
                _dbContext.Dispose();
                GC.SuppressFinalize(this);
            }
        }

        public TContext Init() => _dbContext ??= _instanceFunc.Invoke();

    }
}
