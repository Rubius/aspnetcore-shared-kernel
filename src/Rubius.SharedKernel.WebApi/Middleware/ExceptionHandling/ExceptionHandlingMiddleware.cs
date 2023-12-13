using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Rubius.SharedKernel.Domain.Exceptions;

namespace Rubius.SharedKernel.WebApi.Middleware.ExceptionHandling;

internal sealed class ExceptionHandlingMiddleware : IMiddleware
{
    private const string ExceptionLogMessage = "An exception occurred";

    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(ILogger<ExceptionHandlingMiddleware> logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (SharedKernelException ex)
        {
            _logger.LogError(ex, ExceptionLogMessage);

            await HandleSharedKernelExceptionAsync(context, ex);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ExceptionLogMessage);

            await HandleExceptionAsync(context);
        }
    }

    private static async Task HandleSharedKernelExceptionAsync(HttpContext context, SharedKernelException exception)
    {
        context.Response.StatusCode = exception.StatusCode;

        await context.Response.WriteAsJsonAsync(exception.Message);
    }

    private static async Task HandleExceptionAsync(HttpContext context)
    {
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        await context.Response.WriteAsJsonAsync("Internal Server Error");
    }
}