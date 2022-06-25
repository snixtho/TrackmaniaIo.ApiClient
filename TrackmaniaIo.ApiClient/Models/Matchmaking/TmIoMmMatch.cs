namespace TrackmaniaIo.ApiClient.Models.Matchmaking;

public class TmIoMmMatch
{
    public int AfterScore { get; set; }
    public bool Leave { get; set; }
    public string? Lid { get; set; }
    public bool Mvp { get; set; }
    public DateTime StartTime { get; set; }
    public int TypeId { get; set; }
    public string? TypeName { get; set; }
    public bool Win { get; set; }
}