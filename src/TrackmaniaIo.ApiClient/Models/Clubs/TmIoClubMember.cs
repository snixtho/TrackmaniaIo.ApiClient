using System.Text.Json.Serialization;
using TrackmaniaIo.ApiClient.Models.Players;
using TrackmaniaIo.ApiClient.Utils.ValueConverters;

namespace TrackmaniaIo.ApiClient.Models.Clubs;

public class TmIoClubMember
{
    [JsonConverter(typeof(UnixToDatetimeConverter))]
    public DateTime JoinTime { get; set; }
    public string? Role { get; set; }
    public bool Vip { get; set; }
    public TmIoPlayerInfo? Player { get; set; }
}