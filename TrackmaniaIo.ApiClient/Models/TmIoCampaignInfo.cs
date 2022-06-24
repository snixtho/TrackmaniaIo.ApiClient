using System.Text.Json.Serialization;
using TrackmaniaIo.ApiClient.Utils.ValueConverters;

namespace TrackmaniaIo.ApiClient.Models;

public class TmIoCampaignInfo
{
    public int ClubId { get; set; }
    [JsonConverter(typeof(UnixToDatetimeConverter))]
    public DateTime CreationTime { get; set; }
    public long Id { get; set; }
    public string? LeaderboardUid { get; set; }
    public string? Media { get; set; }
    public IEnumerable<TmIoMediaInfo>? Mediae { get; set; }
    public string? Name { get; set; }
    public IEnumerable<TmIoMapInfo>? PlayList { get; set; }
    [JsonConverter(typeof(UnixToDatetimeConverter))]
    public DateTime PublishTime { get; set; }
    public bool Tracked { get; set; }
}