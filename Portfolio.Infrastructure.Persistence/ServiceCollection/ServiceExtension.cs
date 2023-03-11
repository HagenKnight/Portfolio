using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Infrastructure.Persistence.Data;

namespace Portfolio.Infrastructure.Persistence.ServiceCollection
{
    public static class ServiceExtension
    {
        public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            /* Contextos de Bases de Datos. */
            string? connectionString = configuration.GetConnectionString("PortfolioConnection");
            services.AddDbContext<PortfolioDbContext>(options => { options.UseSqlServer(connectionString); });

            /* DbFactory pattern. */
            /* Agregar aquí las implementaciones de Factory Pattern, asociadas a cada conexto de Base de Datos... */
            services.AddScoped<Func<PortfolioDbContext>>((provider) => () => provider.GetService<PortfolioDbContext>());
        }
    }
}
