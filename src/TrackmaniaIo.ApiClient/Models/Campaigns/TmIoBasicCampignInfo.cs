using System.Text.Json.Serialization;
using TrackmaniaIo.ApiClient.Utils.ValueConverters;

namespace TrackmaniaIo.ApiClient.Models.Campaigns;

public class TmIoBasicCampignInfo
{
    public int ClubId { get; set; }
    public long Id { get; set; }
    public int MapCount { get; set; }
    public string? Name { get; set; }
    [JsonConverter(typeof(UnixToDatetimeConverter))]
    public DateTime Timestamp { get; set; }
}