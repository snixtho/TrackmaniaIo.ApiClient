namespace TrackmaniaIo.ApiClient.Models;

public class TmIoCotdCompetitionList
{
    public IEnumerable<TmIoCotdBasicCompetitionInfo>? Competitions { get; set; }
    public int Page { get; set; }
    public int PageMax { get; set; }
}