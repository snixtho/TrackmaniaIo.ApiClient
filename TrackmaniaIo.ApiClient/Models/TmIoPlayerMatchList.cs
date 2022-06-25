namespace TrackmaniaIo.ApiClient.Models;

public class TmIoPlayerMatchList : TmIoPlayerEntryList
{
    public IEnumerable<TmIoMmMatch>? Matches { get; set; }
}