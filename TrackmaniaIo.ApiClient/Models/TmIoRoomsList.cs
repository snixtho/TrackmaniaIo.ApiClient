namespace TrackmaniaIo.ApiClient.Models;

public class TmIoRoomsList
{
    public int Page { get; set; }
    public IEnumerable<TmIoRoomInfo>? Rooms { get; set; }
}