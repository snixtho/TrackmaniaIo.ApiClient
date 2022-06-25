namespace TrackmaniaIo.ApiClient.Models.Events;

public class TmIoCompetitionRoundInfo
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Status { get; set; }
    public IEnumerable<TmIoCompetitionChallengeInfo>? Challenges { get; set; }
    public IEnumerable<TmIoCompetitionMatchInfo>? Matches { get; set; }
}