using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Rubius.SharedKernel.Application.AutoMapper;

namespace Rubius.SharedKernel.Infrastructure;

public static class InfrastructureSharedKernelModule
{
    public static IServiceCollection AddInfrastructureSharedKernelModule(this IServiceCollection services,
        Assembly infrastructureAssembly)
    {
        services.AddAutoMapperModule(infrastructureAssembly);

        return services;
    }
}