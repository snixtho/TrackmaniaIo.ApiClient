namespace TrackmaniaIo.ApiClient.Models.Events;

public class TmIoCompetitionResult
{
    public string? Unit { get; set; }
    public IEnumerable<TmIoCompetitionResultPosition>? Results { get; set; }
}