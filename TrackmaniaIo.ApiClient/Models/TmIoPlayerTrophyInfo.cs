namespace TrackmaniaIo.ApiClient.Models;

public class TmIoPlayerTrophyInfo
{
    public IEnumerable<int>? Counts { get; set; }
    public int Echelon { get; set; }
    public long Points { get; set; }
    public DateTime Timestamp { get; set; }
    public TmIoZoneInfo? Zone { get; set; }
    public IEnumerable<int>? ZonePositions { get; set; }
}