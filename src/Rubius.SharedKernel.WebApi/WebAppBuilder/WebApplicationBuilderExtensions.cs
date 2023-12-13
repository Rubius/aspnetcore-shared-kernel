using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Rubius.SharedKernel.WebApi.Middleware.CORS;
using Rubius.SharedKernel.WebApi.Middleware.ExceptionHandling;
using Rubius.SharedKernel.WebApi.Middleware.Swagger;
using Rubius.SharedKernel.WebApi.NewtonsoftJson;

namespace Rubius.SharedKernel.WebApi.WebAppBuilder;

internal static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder ConfigureWebApplicationBuilder(this WebApplicationBuilder builder,
        Action<WebApplicationBuilder>? builderAction = null)
    {
        builder.AddCorsMiddleware()
            .AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true)
            .AddNewtonsoftJsonModule()
            .AddEndpointsApiExplorer()
            .AddSwaggerMiddleware()
            .AddExceptionHandlingMiddleware();

        builderAction?.Invoke(builder);

        return builder;
    }
}