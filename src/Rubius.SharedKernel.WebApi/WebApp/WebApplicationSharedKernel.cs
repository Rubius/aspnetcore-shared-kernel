using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Rubius.SharedKernel.WebApi.Logging;
using Rubius.SharedKernel.WebApi.WebAppBuilder;

namespace Rubius.SharedKernel.WebApi.WebApp;

/// <summary>
/// Класс для запуска приложения с базовой конфигурацией
/// </summary>
public sealed class WebApplicationSharedKernel
{
    private readonly WebApplicationBuilder _builder;

    private readonly WebApplicationSharedKernelBuilder? _sharedKernelBuilder;

    internal WebApplicationSharedKernel(WebApplicationBuilder builder, WebApplicationSharedKernelBuilder? sharedKernelBuilder)
    {
        _builder = builder;
        _sharedKernelBuilder = sharedKernelBuilder;
    }

    /// <summary>
    /// Запустить приложение
    /// </summary>
    /// <param name="url">URL адрес для прослушивания, если сервер не был настроен напрямую</param>
    public async Task RunAsync(string? url = null)
    {
        var logger = _builder.AddLogging(_sharedKernelBuilder?.LoggingAction)
            .GetLogger();

        logger.LogInformation("Starting application");

        try
        {
            _builder.ConfigureWebApplicationBuilder(_sharedKernelBuilder?.BuilderAction);

            var app = _builder.Build();

            await app.ConfigureWebApplicationAsync(_sharedKernelBuilder?.AppAction);

            await app.RunAsync(url);
        }
        catch (Exception ex)
        {
            logger.LogCritical(ex, "Application terminated unexpectedly");
        }
    }
}