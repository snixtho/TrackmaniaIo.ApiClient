namespace TrackmaniaIo.ApiClient.Models.Clubs;

public class TmIoClubActivityList
{
    public int Page { get; set; }
    public int PageMax { get; set; }
    public IEnumerable<TmIoClubActivity>? Activities { get; set; }
}