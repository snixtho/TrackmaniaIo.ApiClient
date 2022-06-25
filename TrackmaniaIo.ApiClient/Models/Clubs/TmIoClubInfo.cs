using System.Text.Json.Serialization;
using TrackmaniaIo.ApiClient.Models.Players;
using TrackmaniaIo.ApiClient.Utils.ValueConverters;

namespace TrackmaniaIo.ApiClient.Models.Clubs;

public class TmIoClubInfo
{
    public string? BackgroundUrl { get; set; }
    public int CreationDate { get; set; }
    [JsonConverter(typeof(UnixToDatetimeConverter))]
    public DateTime CreationTimestamp { get; set; }
    public TmIoPlayerInfo? CreatorPlayer { get; set; }
    public string? DecalSponsor4X1Url { get; set; }
    public string? DecalUrl { get; set; }
    public string? Description { get; set; }
    public bool Featured { get; set; }
    public string? IconUrl { get; set; }
    public int Id { get; set; }
    public string? LogoUrl { get; set; }
    public int MemberCount { get; set; }
    public string? Name { get; set; }
    public int PopularityLevel { get; set; }
    public string? Screen2X1Url { get; set; }
    public string? Screen8X1Url { get; set; }
    public string? Screen16X1Url { get; set; }
    public string? Screen16X9Url { get; set; }
    public string? Tag { get; set; }
    public string? VerticalUrl { get; set; }
}