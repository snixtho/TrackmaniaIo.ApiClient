using System.Text.Json.Serialization;
using TrackmaniaIo.ApiClient.Utils.ValueConverters;

namespace TrackmaniaIo.ApiClient.Models.Cotd;

public class TmIoCotdLeaderboard
{
    public int Page { get; set; }
    [JsonConverter(typeof(NullableDatetimeConverter))]
    public DateTime? Timestamp { get; set; }
    public IEnumerable<TmIoCotdLeaderboardPosition>? Players { get; set; }
}