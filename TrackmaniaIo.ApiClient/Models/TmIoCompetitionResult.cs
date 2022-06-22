namespace TrackmaniaIo.ApiClient.Models;

public class TmIoCompetitionResult
{
    public string Unit { get; set; }
    public IEnumerable<TmIoCompetitionResultPosition>? Results { get; set; }
}