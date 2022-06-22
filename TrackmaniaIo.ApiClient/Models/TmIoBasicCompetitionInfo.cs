using System.Text.Json.Serialization;
using TrackmaniaIo.ApiClient.Utils.ValueConverters;

namespace TrackmaniaIo.ApiClient.Models;

public class TmIoBasicCompetitionInfo
{
    [JsonConverter(typeof(UnixToDatetimeConverter))]
    public DateTime StartTime { get; set; }
    [JsonConverter(typeof(UnixToDatetimeConverter))]
    public DateTime EndTime { get; set; }
    public long Id { get; set; }
    public long Players { get; set; }
    public string? Name { get; set; }
}