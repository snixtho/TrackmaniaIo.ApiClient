namespace TrackmaniaIo.ApiClient.Models.Campaigns;

public class TmIoCampaignList
{
    public int Page { get; set; }
    public IEnumerable<TmIoBasicCampignInfo>? Campaigns { get; set; }
}