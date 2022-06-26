using TrackmaniaIo.ApiClient.Models.Matchmaking;

namespace TrackmaniaIo.ApiClient.Models.Players;

public class TmIoPlayerMatchList : TmIoPlayerEntryList
{
    public IEnumerable<TmIoMmMatch>? Matches { get; set; }
}