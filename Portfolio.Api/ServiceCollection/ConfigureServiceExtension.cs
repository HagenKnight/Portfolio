using Microsoft.Extensions.DependencyInjection.Extensions;
using Newtonsoft.Json.Serialization;
using Portfolio.Api.Middleware;
using Portfolio.Application.ServiceCollection;
using Portfolio.Infrastructure.Common.ServiceCollection;
using Portfolio.Infrastructure.Identity;
using Portfolio.Infrastructure.Persistence.ServiceCollection;
using Portfolio.Infrastructure.UnitOfWork.ServiceCollection;

namespace Portfolio.Api.ServiceCollection
{
    public static class ConfigureServiceExtension
    {
        public static void InitConfigurationAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationLayer();
            services.AddPersistenceLayer(configuration);
            services.AddUnitOfWorkLayer();
            services.AddCommonLayer();
            services.AddTransient<ErrorHandlerMiddleware>();
            services.AddControllers().AddNewtonsoftJson(options =>
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

            /* Puede ser también: services.AddHttpContextAccessor(); */
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            // call Identity services builder
            services.ConfigureIdentityServices(configuration);

            services.AddCors(options =>
            {
                options.AddPolicy("CorsePolicy", builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                );
            });

        }
    }
}
