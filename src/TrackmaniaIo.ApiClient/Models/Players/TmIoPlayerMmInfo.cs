using TrackmaniaIo.ApiClient.Models.Matchmaking;

namespace TrackmaniaIo.ApiClient.Models.Players;

public class TmIoPlayerMmInfo
{
    public long Total { get; set; }
    public TmIoMatchmakingInfo? Info { get; set; }
}