using TrackmaniaIo.ApiClient.Models.Matchmaking;

namespace TrackmaniaIo.ApiClient.Models.Players;

public class TmIoPlayerSearchEntry
{
    public TmIoPlayerInfo? Player { get; set; }
    public IEnumerable<TmIoMatchmakingInfo>? Matchmaking { get; set; }
}