namespace TrackmaniaIo.ApiClient.Models;

public class TmIoTotdDay
{
    public int CampaignId { get; set; }
    public int WeekDay { get; set; }
    public int MonthDay { get; set; }
    public string? LeaderboardUid { get; set; }
}