using Dump_Catastro_CORE.Interfaces;
using Dump_Catastro_INFRASTRUCTURE.Data;
using Dump_Catastro_INFRASTRUCTURE.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dump_Catastro_INFRASTRUCTURE.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbcatastroContext>(options =>
               options.UseNpgsql(configuration.GetConnectionString("CatastroConnection"))
           );

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }

        //public static IServiceCollection AddSwagger(this IServiceCollection services)
        //{
        //    services.AddSwaggerGen(doc =>
        //    {
        //        doc.SwaggerDoc("v1", new OpenApiInfo { Title = "DUMP CATASTRO API", Version = "v1" });
        //    });

        //    return services;
        //}

    }
}
