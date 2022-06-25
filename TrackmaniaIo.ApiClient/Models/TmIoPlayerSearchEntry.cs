namespace TrackmaniaIo.ApiClient.Models;

public class TmIoPlayerSearchEntry
{
    public TmIoPlayerInfo? Player { get; set; }
    public IEnumerable<TmIoMatchmakingInfo>? Matchmaking { get; set; }
}