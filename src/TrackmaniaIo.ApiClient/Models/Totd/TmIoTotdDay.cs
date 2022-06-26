using TrackmaniaIo.ApiClient.Models.Maps;

namespace TrackmaniaIo.ApiClient.Models.Totd;

public class TmIoTotdDay
{
    public int CampaignId { get; set; }
    public int WeekDay { get; set; }
    public int MonthDay { get; set; }
    public string? LeaderboardUid { get; set; }
    public TmIoMapInfo? Map { get; set; }
}