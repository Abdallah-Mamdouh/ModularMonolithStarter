using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Shared.Messagaing.Extentions
{
    public static class MassTransitExtentions
    {
        public static IServiceCollection AddMassTransitWithAssemblies
        (this IServiceCollection services, IConfiguration configuration, params Assembly[] assemblies)
        {
            // Implement MassTransit Configuration
            services.AddMassTransit(config =>
            {
                config.SetKebabCaseEndpointNameFormatter();

                config.SetInMemorySagaRepositoryProvider();

                config.AddConsumers(assemblies);
                config.AddSagaStateMachines(assemblies);
                config.AddSagas(assemblies);
                config.AddActivities(assemblies);

                config.UsingRabbitMq((context, configurator) =>
                {
                    configurator.Host(new Uri(configuration["MessageBroker:Host"]!), host =>
                    {
                        host.Username(configuration["MessageBroker:UserName"]!);
                        host.Password(configuration["MessageBroker:Password"]!);
                    });
                    configurator.ConfigureEndpoints(context);
                });

                //config.UsingInMemory((context, configuration) =>
                //{
                //    configuration.ConfigureEndpoints(context);
                //});
            });

            return services;
        }
    }
}
