using System.Globalization;
using Newtonsoft.Json;
using Rubius.SharedKernel.Domain.DateTime.Constants;

namespace Rubius.SharedKernel.WebApi.NewtonsoftJson.Converters;

internal class DateOnlyJsonConverter : JsonConverter<DateOnly>
{
    public override DateOnly ReadJson(JsonReader reader, Type objectType, DateOnly existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        return DateOnly.ParseExact((string)reader.Value!, DateOnlyConstants.DefaultFormat, CultureInfo.InvariantCulture);
    }

    public override void WriteJson(JsonWriter writer, DateOnly value, JsonSerializer serializer)
    {
        writer.WriteValue(value.ToString(DateOnlyConstants.DefaultFormat, CultureInfo.InvariantCulture));
    }
}