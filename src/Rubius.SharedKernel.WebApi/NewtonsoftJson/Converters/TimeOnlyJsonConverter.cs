using System.Globalization;
using Newtonsoft.Json;
using Rubius.SharedKernel.Domain.DateTime.Constants;

namespace Rubius.SharedKernel.WebApi.NewtonsoftJson.Converters;

internal class TimeOnlyJsonConverter : JsonConverter<TimeOnly>
{
    public override TimeOnly ReadJson(JsonReader reader, Type objectType, TimeOnly existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        return TimeOnly.ParseExact((string)reader.Value!, TimeOnlyConstants.DefaultFormat, CultureInfo.InvariantCulture);
    }

    public override void WriteJson(JsonWriter writer, TimeOnly value, JsonSerializer serializer)
    {
        writer.WriteValue(value.ToString(TimeOnlyConstants.DefaultFormat, CultureInfo.InvariantCulture));
    }
}