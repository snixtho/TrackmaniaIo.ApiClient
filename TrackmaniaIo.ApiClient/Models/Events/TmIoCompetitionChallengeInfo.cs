using TrackmaniaIo.ApiClient.Models.Players;

namespace TrackmaniaIo.ApiClient.Models.Events;

public class TmIoCompetitionChallengeInfo
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Status { get; set; }
    public int Servers { get; set; }
    public IEnumerable<TmIoAccountInfo>? Admins { get; set; }
}