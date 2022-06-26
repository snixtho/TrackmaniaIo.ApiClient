namespace TrackmaniaIo.ApiClient.Models.Players;

public class TmIoPlayerProfile
{
    public string? AccountId { get; set; }
    public string? DisplayName { get; set; }
    public DateTime Timestamp { get; set; }
    public TmIoPlayerMetaInfo? Meta { get; set; }
    public TmIoPlayerTrophyInfo? Trophies { get; set; }
    public IEnumerable<TmIoPlayerMmInfo>? Matchmaking { get; set; }
}