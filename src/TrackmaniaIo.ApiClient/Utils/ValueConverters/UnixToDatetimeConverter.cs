using System.Text.Json;
using System.Text.Json.Serialization;

namespace TrackmaniaIo.ApiClient.Utils.ValueConverters;

public class UnixToDatetimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetInt64();
        return new DateTime(1970, 1, 1).AddSeconds(value);
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
    }
}