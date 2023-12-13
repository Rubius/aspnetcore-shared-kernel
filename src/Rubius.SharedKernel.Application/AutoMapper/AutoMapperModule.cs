using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Rubius.SharedKernel.Application.AutoMapper;

public static class AutoMapperModule
{
    public static IServiceCollection AddAutoMapperModule(this IServiceCollection services, Assembly assembly)
    {
        services.AddAutoMapper(assembly);

        return services;
    }
}