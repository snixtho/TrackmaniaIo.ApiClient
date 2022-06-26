using TrackmaniaIo.ApiClient.Models.Players;

namespace TrackmaniaIo.ApiClient.Models.Leaderboards;

public class TmIoLeaderboardPosition
{
    public long Position { get; set; }
    public TmIoPlayerInfo? Player { get; set; }
    public int Time { get; set; }
    public string? FileName { get; set; }
    public DateTime Timestamp { get; set; }
    public string? Url { get; set; }
}