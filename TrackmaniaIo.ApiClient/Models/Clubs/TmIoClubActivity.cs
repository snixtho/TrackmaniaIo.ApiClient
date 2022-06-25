namespace TrackmaniaIo.ApiClient.Models.Clubs;

public class TmIoClubActivity
{
    public long ActivityId { get; set; }
    public long Id { get; set; }
    public string? Media { get; set; }
    public string? Name { get; set; }
    public bool Password { get; set; }
    public int Position { get; set; }
    public bool Public { get; set; }
    public long TargetActivityId { get; set; }
    public string? Type { get; set; }
}