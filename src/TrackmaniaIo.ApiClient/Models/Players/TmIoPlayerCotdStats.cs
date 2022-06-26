namespace TrackmaniaIo.ApiClient.Models.Players;

public class TmIoPlayerCotdStats
{
    public double AvgDiv { get; set; }
    public double AvgDivRank { get; set; }
    public double AvgRank { get; set; }
    public int DivWinStreak { get; set; }
    public int TotalDivWins { get; set; }
    public int TotalWins { get; set; }
    public int WinStreak { get; set; }
    public TmIoPlayerBestCotdResultInfo? BestOverall { get; set; }
    public TmIoPlayerBestCotdResultInfo? BestPrimary { get; set; }
}