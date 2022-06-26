namespace TrackmaniaIo.ApiClient.Models.Clubs;

public class TmIoClubList
{
    public int Page { get; set; }
    public IEnumerable<TmIoClubInfo>? Clubs { get; set; }
}