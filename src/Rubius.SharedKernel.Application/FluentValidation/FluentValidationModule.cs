using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;

namespace Rubius.SharedKernel.Application.FluentValidation;

internal static class FluentValidationModule
{
    public static IServiceCollection AddFluentValidationModule(this IServiceCollection services, Assembly assembly)
    {
        services.AddValidatorsFromAssembly(assembly);
        services.AddFluentValidationAutoValidation();

        return services;
    }
}