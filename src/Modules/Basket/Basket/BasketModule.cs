using Basket.Data.Processors;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Data;
using Shared.Data.Interceptors;

namespace Basket
{
    public static class BasketModule
    {
        public static IServiceCollection AddBasketModule (this IServiceCollection services,
            IConfiguration configuration)
        {
            // Add services to the container

            // Api endpoint services

            // Application use case services
            services.AddScoped<IBasketRepository, BasketRepository>();
            services.Decorate<IBasketRepository, CachedBasketRepository>();

            // Data - infrastructure services
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddScoped<ISaveChangesInterceptor, AuditableEntityInterceptor>();
            services.AddScoped<ISaveChangesInterceptor, DispatchDomainEventsInterceptor>();

            services.AddDbContext<BasketDbContext>((sp, options) =>
            {
                options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());
                options.UseNpgsql(connectionString);
            });

            services.AddHostedService<OutboxProcessor>();

            return services;
        }

        public static IApplicationBuilder UseBasketModule (this IApplicationBuilder app)
        {
            // Configure the HTTP request pipeline.

            // Use Api endpoint services

            // Use Application use case services

            // Use Data - infrastructure services
            app.UseMigration<BasketDbContext>();

            return app;
        }
    }
}
