using Microsoft.AspNetCore.Builder;
using Rubius.SharedKernel.WebApi.WebApp;
using Rubius.SharedKernel.WebApi.WebAppBuilder;

namespace Rubius.SharedKernel.WebApi;

public static class WebApiSharedKernelModule
{
    public static WebApplicationSharedKernel AddWebApiSharedKernelModule(this WebApplicationBuilder builder,
        Func<WebApplicationSharedKernelBuilder, WebApplicationSharedKernelBuilder>? sharedKernelBuilderAction = null)
    {
        var sharedKernelBuilder = sharedKernelBuilderAction?.Invoke(new WebApplicationSharedKernelBuilder());

        return new WebApplicationSharedKernel(builder, sharedKernelBuilder);
    }
}