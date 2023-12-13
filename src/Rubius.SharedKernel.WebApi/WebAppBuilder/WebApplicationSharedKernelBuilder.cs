using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;

namespace Rubius.SharedKernel.WebApi.WebAppBuilder;

/// <summary>
/// Билдер для WebApplicationSharedKernel
/// </summary>
public sealed class WebApplicationSharedKernelBuilder
{
    internal WebApplicationSharedKernelBuilder()
    {
    }

    internal Action<ILoggingBuilder>? LoggingAction { get; private set; }

    internal Action<WebApplicationBuilder>? BuilderAction { get; private set; }

    internal Func<WebApplication, Task>? AppAction { get; private set; }

    /// <summary>
    /// Сконфигурировать логирование
    /// </summary>
    public WebApplicationSharedKernelBuilder ConfigureLogging(Action<ILoggingBuilder> loggingAction)
    {
        LoggingAction = loggingAction;

        return this;
    }

    /// <summary>
    /// Сконфигурировать WebApplicationBuilder
    /// </summary>
    public WebApplicationSharedKernelBuilder ConfigureWebApplicationBuilder(Action<WebApplicationBuilder> builderAction)
    {
        BuilderAction = builderAction;

        return this;
    }

    /// <summary>
    /// Сконфигурировать WebApplication
    /// </summary>
    public WebApplicationSharedKernelBuilder ConfigureWebApplication(Func<WebApplication, Task> appAction)
    {
        AppAction = appAction;

        return this;
    }
}