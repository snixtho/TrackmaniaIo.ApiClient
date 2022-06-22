using System.Text.Json.Serialization;
using TrackmaniaIo.ApiClient.Utils.ValueConverters;

namespace TrackmaniaIo.ApiClient.Models;

public class TmIoCompetitionInfo
{
    public TmIoPlayerInfo? CreatorPlayer { get; set; }
    public string? Description { get; set; }
    [JsonConverter(typeof(UnixToDatetimeConverter))]
    public DateTime EndDate { get; set; }
    public long Id { get; set; }
    public long LeaderboardId { get; set; }
    public string? LiveId { get; set; }
    public string? LogoUrl { get; set; }
    public string? Name { get; set; }
    public long NumPlayers { get; set; }
    [JsonConverter(typeof(UnixToDatetimeConverter))]
    public DateTime RegistrationEnd { get; set; }
    [JsonConverter(typeof(UnixToDatetimeConverter))]
    public DateTime RegistrationStart { get; set; }
    public string? RulesUrl { get; set; }
    [JsonConverter(typeof(UnixToDatetimeConverter))]
    public DateTime StartDate { get; set; }
    public string? VerticalUrl { get; set; }
    public string? WebsiteUrl { get; set; }
    public IEnumerable<TmIoCompetitionRoundInfo>? Rounds { get; set; }
}