namespace TrackmaniaIo.ApiClient.Models;

public class TmIoZoneInfo
{
    public string? Name { get; set; }
    public string? Flag { get; set; }
    public TmIoZoneInfo? Parent { get; set; }
}