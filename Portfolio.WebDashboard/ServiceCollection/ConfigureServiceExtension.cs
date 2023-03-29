using Newtonsoft.Json.Serialization;
using Portfolio.Application.ServiceCollection;
using Portfolio.Infrastructure.Persistence.ServiceCollection;
using Portfolio.Infrastructure.UnitOfWork.ServiceCollection;
using Portfolio.Infrastructure.Common.ServiceCollection;
using Portfolio.WebDashboard.Middleware;

namespace Portfolio.WebDashboard.ServiceCollection
{
    public static class ConfigureServiceExtension
    {
        public static void InitConfigurationApp(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationLayer();
            services.AddPersistenceLayer(configuration);
            services.AddUnitOfWorkLayer();
            services.AddCommonLayer();
            services.AddTransient<ErrorHandlerMiddleware>();
            services.AddControllersWithViews().AddNewtonsoftJson(options =>
            {
                options.UseCamelCasing(true);
                options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                options.SerializerSettings.Culture = System.Globalization.CultureInfo.CurrentCulture;
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                options.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Local;
                options.SerializerSettings.FloatFormatHandling = Newtonsoft.Json.FloatFormatHandling.DefaultValue;
                options.SerializerSettings.FloatParseHandling = Newtonsoft.Json.FloatParseHandling.Decimal;
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });
            
        }
    }
}
