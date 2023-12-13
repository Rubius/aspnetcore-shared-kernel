using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Rubius.SharedKernel.WebApi.Middleware.CORS;
using Rubius.SharedKernel.WebApi.Middleware.ExceptionHandling;
using Rubius.SharedKernel.WebApi.Middleware.Swagger;

namespace Rubius.SharedKernel.WebApi.WebApp;

internal static class WebApplicationExtensions
{
    public static async Task<WebApplication> ConfigureWebApplicationAsync(this WebApplication app,
        Func<WebApplication, Task>? appConfigure = null)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwaggerMiddleware();
        }

        app.UseExceptionHandlingMiddleware();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.UseCorsMiddleware();

        if (appConfigure is not null)
        {
            await appConfigure.Invoke(app);
        }

        return app;
    }
}