using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Rubius.SharedKernel.WebApi.Logging;

internal static class LoggingExtensions
{
    public static WebApplicationBuilder AddLogging(this WebApplicationBuilder builder, Action<ILoggingBuilder>? loggingAction)
    {
        if (loggingAction is not null)
        {
            builder.Services.AddLogging(loggingAction);
        }

        return builder;
    }

    public static ILogger<ILogger> GetLogger(this WebApplicationBuilder builder)
    {
        return builder.Services
            .BuildServiceProvider()
            .GetRequiredService<ILogger<ILogger>>();
    }
}