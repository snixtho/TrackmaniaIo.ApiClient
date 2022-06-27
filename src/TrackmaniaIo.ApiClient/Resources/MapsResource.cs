using TrackmaniaIo.ApiClient.Models.Maps;

namespace TrackmaniaIo.ApiClient.Resources;

/// <summary>
/// Uploaded maps
/// </summary>
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

    public Task<Stream> DownloadMapAsync(TmIoMapInfo mapInfo)
    {
        if (mapInfo.FileUrl == null || mapInfo.FileUrl.Trim() == "")
            throw new InvalidOperationException("File URL of the map is null or empty.");

        return WithMethod(HttpMethod.Get)
            .WithBaseUrl(mapInfo.FileUrl)
            .RequestStreamAsync();
    }

}