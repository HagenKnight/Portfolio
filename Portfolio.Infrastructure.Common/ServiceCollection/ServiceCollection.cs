using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Core.Interfaces.Management;
using Portfolio.Core.Interfaces.Repository;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Models;
using Portfolio.Infrastructure.Common.Helpers;
using Portfolio.Infrastructure.Common.Repositories;
using Portfolio.Infrastructure.Common.Services;
using Portfolio.Infrastructure.Persistence.Data;

namespace Portfolio.Infrastructure.Common.ServiceCollection
{
    public static class ServiceCollection
    {
        public static void AddCommonLayer(this IServiceCollection services, IConfiguration configuration)
        {
            /* Repositories */
            services.AddTransient<ICountryRepository<PortfolioDbContext>, CountryRepository>();
            services.AddTransient<IWorkerProfileRepository<PortfolioDbContext>, WorkerProfileRepository>();
            services.AddTransient<IResumeTypeRepository<PortfolioDbContext>, ResumeTypeRepository>();
            services.AddTransient<IResumeRepository<PortfolioDbContext>, ResumeRepository>();
            services.AddTransient<IAptitudeRepository<PortfolioDbContext>, AptitudeRepository>();

            /* Services */
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IWorkerProfileService, WorkerProfileService>();
            services.AddTransient<IResumeTypeService, ResumeTypeService>();
            services.AddTransient<IResumeService, ResumeService>();
            services.AddTransient<IAptitudeService, AptitudeService>();

            services.Configure<EmailSettings>( configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailService, EmailService>();

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
