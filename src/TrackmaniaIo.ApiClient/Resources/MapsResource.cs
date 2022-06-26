using TrackmaniaIo.ApiClient.Models.Maps;

namespace TrackmaniaIo.ApiClient.Resources;

public class MapsResource : TmIoApiBase<MapsResource>
{
    public MapsResource(string projectName, string contact, string? apiKey = null) : base(projectName, contact, apiKey)
    {
    }

    /// <summary>
    /// Get information about a map given the uid.
    /// </summary>
    /// <param name="uid">UID string of the map.</param>
    /// <returns></returns>
    public Task<TmIoMapInfo?> GetMapAsync(string uid) =>
        WithApiKey()
            .GetJsonAsync<TmIoMapInfo>("/map/{uid}", uid);
}