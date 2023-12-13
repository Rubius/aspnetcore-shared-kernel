using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Rubius.SharedKernel.Application.AutoMapper;
using Rubius.SharedKernel.Application.FluentValidation;
using Rubius.SharedKernel.Application.MediatR;

namespace Rubius.SharedKernel.Application;

public static class ApplicationSharedKernelModule
{
    public static IServiceCollection AddApplicationSharedKernelModule(this IServiceCollection services,
        Assembly applicationAssembly)
    {
        services.AddAutoMapperModule(applicationAssembly);
        services.AddFluentValidationModule(applicationAssembly);
        services.AddMediatrModule(applicationAssembly);

        return services;
    }
}