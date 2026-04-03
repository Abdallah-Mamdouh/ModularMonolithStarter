using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Data.Interceptors;

namespace Catalog
{
    public static class CatalogModule
    {
        public static IServiceCollection AddCatalogModule (this IServiceCollection services,
            IConfiguration configuration)
        {
            // Add services to the container

            // Api endpoint services

            // Application use case services

            // Data - infrastructure services
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<CatalogDbContext>(options =>
            {
                options.AddInterceptors(new AuditableEntityInterceptor());
                options.UseNpgsql(connectionString);
            });

            services.AddScoped<IDataSeed, CatalogDataSeeder>();

            return services;
        }

        public static IApplicationBuilder UseCatalogModule (this IApplicationBuilder app)
        {
            // Configure the HTTP request pipeline.

            // Use Api endpoint services

            // Use Application use case services

            // Use Data - infrastructure services
            app.UseMigration<CatalogDbContext>();

            return app;
        }
    }
}
