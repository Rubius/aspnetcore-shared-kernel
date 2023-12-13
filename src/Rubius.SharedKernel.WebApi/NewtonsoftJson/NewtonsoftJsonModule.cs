using Microsoft.Extensions.DependencyInjection;
using Rubius.SharedKernel.Domain.DateTime.Constants;
using Rubius.SharedKernel.WebApi.NewtonsoftJson.Converters;

namespace Rubius.SharedKernel.WebApi.NewtonsoftJson;

internal static class NewtonsoftJsonModule
{
    public static IServiceCollection AddNewtonsoftJsonModule(this IMvcBuilder builder)
    {
        builder.AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.DateFormatString = DateTimeConstants.DefaultFormat;
            options.SerializerSettings.Converters.Add(new DateOnlyJsonConverter());
            options.SerializerSettings.Converters.Add(new TimeOnlyJsonConverter());
        });

        return builder.Services;
    }
}