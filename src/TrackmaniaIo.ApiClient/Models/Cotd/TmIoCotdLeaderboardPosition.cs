using TrackmaniaIo.ApiClient.Models.Players;

namespace TrackmaniaIo.ApiClient.Models.Cotd;

public class TmIoCotdLeaderboardPosition
{
    public TmIoPlayerInfo? Player { get; set; }
    public long Position { get; set; }
    public int TotalPlayed { get; set; }
    public int TotalPlayedReruns { get; set; }
    public int Wins { get; set; }
    public int WinsReruns { get; set; }
    public int WinStreak { get; set; }
    public int WinStreakReruns { get; set; }
}