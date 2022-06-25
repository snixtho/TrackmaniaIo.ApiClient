namespace TrackmaniaIo.ApiClient.Models.Players;

public class TmIoPlayerInfo
{
    public string? Name { get; set; }
    public string? Id { get; set; }
    public string? Tag { get; set; }
    public TmIoZoneInfo? Zone { get; set; }
    public TmIoPlayerMetaInfo? Meta { get; set; }
}