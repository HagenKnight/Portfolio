using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Core.Entities;
using Portfolio.Core.Interfaces.Management;
using Portfolio.Core.Interfaces.Repository;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Infrastructure.Common.Helpers;
using Portfolio.Infrastructure.Common.Repositories;
using Portfolio.Infrastructure.Common.Services;
using Portfolio.Infrastructure.Persistence.Data;

namespace Portfolio.Infrastructure.Common.ServiceCollection
{
    public static class ServiceCollection
    {
        public static void AddCommonLayer(this IServiceCollection services)
        {
            /* Repositories */
            services.AddTransient<IEntityRepository<PortfolioDbContext>, EntityRepository>();
            services.AddTransient<ICountryRepository<PortfolioDbContext>, CountryRepository>();
            services.AddTransient<IWorkerProfileRepository<PortfolioDbContext>, WorkerProfileRepository>();
            services.AddTransient<IResumeRepository<PortfolioDbContext>, ResumeRepository>();

            /* Services */
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IWorkerProfileService, WorkerProfileService>();
            services.AddTransient<IResumeService, ResumeService>();

            /* Helpers */
            services.AddSingleton<IUriService>(o =>
            {
                var accessor = o.GetRequiredService<IHttpContextAccessor>();
                var request = accessor.HttpContext.Request;
                var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
                return new UriService(uri);
            });
            services.AddScoped(typeof(IDataShapeHelper<>), typeof(DataShapeHelper<>));
            services.AddScoped<IModelHelper, ModelHelper>();
        }
    }
}
