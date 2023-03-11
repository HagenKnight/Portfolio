using Microsoft.Extensions.DependencyInjection;
using Portfolio.Core.Interfaces.Base;
using Portfolio.Infrastructure.Persistence.Data;
using Portfolio.Infrastructure.UnitOfWork.Base;


namespace Portfolio.Infrastructure.UnitOfWork.ServiceCollection
{
    public static class ServiceExtension
    {
        public static void AddUnitOfWorkLayer(this IServiceCollection services)
        {
            /* Factory & Unit Of Work. */
            services.AddScoped<IDbFactory<PortfolioDbContext>, DbFactory<PortfolioDbContext>>();
            services.AddScoped<IUnitOfWork<PortfolioDbContext>, UnitOfWork<PortfolioDbContext>>();
        }
    }
}
