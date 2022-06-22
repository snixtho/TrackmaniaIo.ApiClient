namespace TrackmaniaIo.ApiClient.Models;

public class TmIoMapInfo
{
    public string? Author { get; set; }
    public string? Name { get; set; }
    public string? MapType { get; set; }
    public string? MapStyle { get; set; }
    public int AuthorScore { get; set; }
    public int GoldScore { get; set; }
    public int SilverScore { get; set; }
    public int BronzeScore { get; set; }
    public string? CollectionName { get; set; }
    public string? FileName { get; set; }
    public bool IsPlayable { get; set; }
    public string? MapId { get; set; }
    public string? MapUid { get; set; }
    public string? Submitter { get; set; }
    public DateTime Timestamp { get; set; }
    public string? FileUrl { get; set; }
    public string? ThumbnailUrl { get; set; }
    public long? ExchangeId { get; set; }
    public TmIoPlayerInfo? AuthorPlayer { get; set; }
    public TmIoPlayerInfo? SubmitterPlayer { get; set; }
}