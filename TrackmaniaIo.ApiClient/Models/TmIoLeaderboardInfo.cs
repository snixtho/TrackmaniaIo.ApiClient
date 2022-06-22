namespace TrackmaniaIo.ApiClient.Models;

public class TmIoLeaderboardInfo
{
    public long PlayerCount { get; set; }
    public IEnumerable<TmIoLeaderboardPosition> Tops { get; set; }
}