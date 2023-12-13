using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Rubius.SharedKernel.Application.MediatR;

internal static class MediatrModule
{
    public static IServiceCollection AddMediatrModule(this IServiceCollection services, Assembly assembly)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

        return services;
    }
}