namespace TrackmaniaIo.ApiClient.Models.Players;

public class TmIoPlayerRankList<T>
{
    public int Page { get; set; }
    public IEnumerable<T>? Ranks { get; set; }
}