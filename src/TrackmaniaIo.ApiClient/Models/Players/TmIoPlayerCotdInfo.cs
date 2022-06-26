namespace TrackmaniaIo.ApiClient.Models.Players;

public class TmIoPlayerCotdInfo : TmIoPlayerEntryList
{
    public long Total { get; set; }
    public TmIoPlayerCotdStats? Stats { get; set; }
    public IEnumerable<TmIoPlayerCotdParticipationInfo>? Cotds { get; set; }
}