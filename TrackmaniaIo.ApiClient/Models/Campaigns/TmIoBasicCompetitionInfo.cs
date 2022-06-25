using System.Text.Json.Serialization;
using TrackmaniaIo.ApiClient.Utils.ValueConverters;

namespace TrackmaniaIo.ApiClient.Models.Campaigns;

public class TmIoBasicCompetitionInfo
{
    [JsonConverter(typeof(UnixToDatetimeConverter))]
    public DateTime Timestamp { get; set; }
    public int ClubId { get; set; }
    public int CompetitionId { get; set; }
    public long Id { get; set; }
    public string? Name { get; set; }
}