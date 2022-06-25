namespace TrackmaniaIo.ApiClient.Models;

public class TmIoMmPosition
{
    public TmIoMmDivision? Division { get; set; }
    public TmIoPlayerInfo? Player { get; set; }
    public int Progression { get; set; }
    public long Rank { get; set; }
    public int Score { get; set; }
}