using TrackmaniaIo.ApiClient.Models.Maps;

namespace TrackmaniaIo.ApiClient.Models.Players;

public class TmIoPlayerTrophyGainInfo
{
    public IEnumerable<int>? Counts { get; set; }
    public TmIoPlayerTrophyGainAchievementInfo? Achievement { get; set; }
    public TmIoPlayerTrophyGainDetails? Details { get; set; }
    public TmIoMapInfo? Map { get; set; }
    public DateTime Timestamp { get; set; }
}