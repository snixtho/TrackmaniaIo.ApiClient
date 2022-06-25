namespace TrackmaniaIo.ApiClient.Models.Leaderboards;

public class TmIoLeaderboardInfo
{
    public long PlayerCount { get; set; }
    public IEnumerable<TmIoLeaderboardPosition> Tops { get; set; }
}