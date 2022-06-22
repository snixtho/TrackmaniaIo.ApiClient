namespace TrackmaniaIo.ApiClient.Models;

public class TmIoCompetitionChallengeInfo
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Status { get; set; }
    public int Servers { get; set; }
    public IEnumerable<TmIoAccountInfo>? Admins { get; set; }
}