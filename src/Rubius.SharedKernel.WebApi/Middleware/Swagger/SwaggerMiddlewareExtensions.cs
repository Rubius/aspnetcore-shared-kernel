using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Rubius.SharedKernel.Domain.DateTime.Extensions;
using Rubius.SharedKernel.WebApi.Exceptions;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Rubius.SharedKernel.WebApi.Middleware.Swagger;

internal static class SwaggerMiddlewareExtensions
{
    public static IServiceCollection AddSwaggerMiddleware(this IServiceCollection services)
    {
        return services.AddSwaggerGen(options =>
        {
            options.IncludeXmlCommentsBasedOnDefaultFile();
            options.MapType<DateTime>(() => new OpenApiSchema
            {
                Type = "string",
                Default = new OpenApiString(DateTime.UtcNow.ToDefaultFormat())
            });
            options.MapType<DateOnly>(() => new OpenApiSchema
            {
                Type = "string",
                Default = new OpenApiString(DateOnly.FromDateTime(DateTime.UtcNow).ToDefaultFormat())
            });
            options.MapType<TimeOnly>(() => new OpenApiSchema
            {
                Type = "string",
                Default = new OpenApiString(TimeOnly.FromDateTime(DateTime.UtcNow).ToDefaultFormat())
            });
        });
    }

    public static IApplicationBuilder UseSwaggerMiddleware(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options => options.DisplayRequestDuration());

        return app;
    }

    private static void IncludeXmlCommentsBasedOnDefaultFile(this SwaggerGenOptions options)
    {
        try
        {
            var defaultFilePath = Path.Combine(
                AppContext.BaseDirectory,
                $"{AppDomain.CurrentDomain.FriendlyName}.xml");

            options.IncludeXmlComments(defaultFilePath);
        }
        catch (Exception)
        {
            throw new WebApiException("Error when inject human-friendly descriptions based on XML Comment files\n" +
                                      "Make sure you add '<GenerateDocumentationFile>true</GenerateDocumentationFile>' " +
                                      $"into {AppDomain.CurrentDomain.FriendlyName}.csproj file");
        }
    }
}