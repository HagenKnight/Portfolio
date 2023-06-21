using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using Portfolio.Api.Middleware;
using Portfolio.Application.ServiceCollection;
using Portfolio.Infrastructure.Common.ServiceCollection;
using Portfolio.Infrastructure.Identity;
using Portfolio.Infrastructure.Persistence.ServiceCollection;
using Portfolio.Infrastructure.UnitOfWork.ServiceCollection;
using System.Reflection;

namespace Portfolio.Api.ServiceCollection
{
    public static class ConfigureServiceExtension
    {
        public static void InitConfigurationAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationLayer();
            services.AddPersistenceLayer(configuration);
            services.AddUnitOfWorkLayer();
            services.AddCommonLayer(configuration);
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
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Portfolio API",
                    Description = "An ASP.NET Core Web API for managing Portfolio (CV) items",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Example Contact",
                        Url = new Uri("https://example.com/contact")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Example License",
                        Url = new Uri("https://example.com/license")
                    }
                });

                // using System.Reflection;
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });

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
