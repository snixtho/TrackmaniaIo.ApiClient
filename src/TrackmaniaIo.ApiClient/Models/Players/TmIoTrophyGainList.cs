namespace TrackmaniaIo.ApiClient.Models.Players;

public class TmIoTrophyGainList : TmIoPlayerEntryList
{
    public int Total { get; set; }
    public IEnumerable<TmIoPlayerTrophyGainInfo>? Gains { get; set; }
}