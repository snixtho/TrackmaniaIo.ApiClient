using System.Text.Json;
using System.Text.Json.Serialization;

namespace TrackmaniaIo.ApiClient.Utils.ValueConverters;

public class NullableDatetimeConverter : JsonConverter<DateTime?>
{
    public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();

        if (value == null)
            return null;

        if (value.Trim() == string.Empty)
            return null;

        return DateTime.Parse(value);
    }

    public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
    {
        
    }
}