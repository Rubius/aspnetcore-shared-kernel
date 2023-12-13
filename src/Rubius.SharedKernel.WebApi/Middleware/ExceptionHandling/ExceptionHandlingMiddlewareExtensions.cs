using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Rubius.SharedKernel.WebApi.Middleware.ExceptionHandling;

internal static class ExceptionHandlingMiddlewareExtensions
{
    public static IServiceCollection AddExceptionHandlingMiddleware(this IServiceCollection services)
    {
        return services.AddTransient<ExceptionHandlingMiddleware>();
    }

    public static IApplicationBuilder UseExceptionHandlingMiddleware(this IApplicationBuilder app)
    {
        return app.UseMiddleware<ExceptionHandlingMiddleware>();
    }
}