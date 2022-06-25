namespace TrackmaniaIo.ApiClient.Models;

public class TmIoTropyRankPosition
{
    public long Rank { get; set; }
    public long Score { get; set; }
    public TmIoPlayerInfo? Player { get; set; }
}