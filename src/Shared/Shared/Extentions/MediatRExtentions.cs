using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Behaviors;
using System.Reflection;

namespace Shared.Extentions
{
    public static class MediatRExtentions
    {
        public static IServiceCollection AddMediatRAssemblies(this IServiceCollection services, params Assembly[] assemblies)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblies(assemblies); // register handlers (IRequestHandler, INotificationHandler ...)
                config.AddOpenBehavior(typeof(ValidationBehavior<,>));
                config.AddOpenBehavior(typeof(LoggingBehavior<,>));
            });
            services.AddValidatorsFromAssemblies(assemblies); // register classes inhert from AbstractValidator

            return services;
        }
    }
}
