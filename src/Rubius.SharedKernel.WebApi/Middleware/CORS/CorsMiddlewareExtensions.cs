using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Rubius.SharedKernel.WebApi.Middleware.CORS;

internal static class CorsMiddlewareExtensions
{
    private const string SectionName = "CorsOrigins";

    private const string SharedKernelCorsPolicy = nameof(SharedKernelCorsPolicy);

    public static IServiceCollection AddCorsMiddleware(this WebApplicationBuilder builder)
    {
        var corsOrigins = builder.Configuration.GetCorsOrigins();

        if (corsOrigins is not null)
        {
            builder.Services.AddCors(options =>
                options.AddPolicy(SharedKernelCorsPolicy, policyBuilder =>
                    policyBuilder.WithOrigins(corsOrigins)
                        .AllowAnyMethod()
                        .AllowAnyHeader()));
        }

        return builder.Services;
    }

    public static void UseCorsMiddleware(this IApplicationBuilder builder)
    {
        builder.UseCors(SharedKernelCorsPolicy);
    }

    private static string[]? GetCorsOrigins(this IConfiguration configuration)
    {
        return configuration.GetSection(SectionName).Get<string[]>();
    }
}