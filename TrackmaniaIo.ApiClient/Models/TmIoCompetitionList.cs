namespace TrackmaniaIo.ApiClient.Models;

public class TmIoCompetitionList
{
    public IEnumerable<TmIoBasicCompetitionInfo>? Competitions { get; set; }
    public int Page { get; set; }
    public int PageMax { get; set; }
}