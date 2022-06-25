using TrackmaniaIo.ApiClient.Models.Players;

namespace TrackmaniaIo.ApiClient.Models.Events;

public class TmIoCompetitionResultPosition
{
    public TmIoPlayerInfo? Player { get; set; }
    public int Position { get; set; }
    public long Score { get; set; }
}