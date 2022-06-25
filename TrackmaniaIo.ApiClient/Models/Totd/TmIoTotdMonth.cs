namespace TrackmaniaIo.ApiClient.Models.Totd;

public class TmIoTotdMonth
{
    public int Year { get; set; }
    public int Month { get; set; }
    public int LastDay { get; set; }
    public int MonthOffset { get; set; }
    public int MonthCount { get; set; }
    public IEnumerable<TmIoTotdDay>? Days { get; set; }
}