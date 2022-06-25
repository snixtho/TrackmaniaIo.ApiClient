using TrackmaniaIo.ApiClient.Models.Rooms;

namespace TrackmaniaIo.ApiClient.Resources;

public class RoomsResource : TmIoApiBase<RoomsResource>
{
    public RoomsResource(string projectName, string contact, string? apiKey = null) : base(projectName, contact, apiKey)
    {
    }

    /// <summary>
    /// Get a list of club rooms.
    /// </summary>
    /// <param name="page">The pagination number.</param>
    /// <returns></returns>
    public Task<TmIoRoomsList?> GetRoomListAsync(int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoRoomsList>("/rooms/{page}", page);

    /// <summary>
    /// Get info about a room.
    /// </summary>
    /// <param name="id">ID of the room.</param>
    /// <returns></returns>
    public Task<TmIoRoomInfo?> GetRoomAsync(long id) =>
        WithApiKey()
            .GetJsonAsync<TmIoRoomInfo>("/room/{id}", id);
}