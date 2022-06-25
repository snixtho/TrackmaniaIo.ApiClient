using TrackmaniaIo.ApiClient.Models.Campaigns;

namespace TrackmaniaIo.ApiClient.Models.Events;

public class TmIoCompetitionList
{
    public IEnumerable<TmIoBasicCompetitionInfo>? Competitions { get; set; }
    public int Page { get; set; }
    public int PageMax { get; set; }
}