using TrackmaniaIo.ApiClient.Models;

namespace TrackmaniaIo.ApiClient.Resources;

public class ManiaPubResource : TmIoApiBase<ManiaPubResource>
{
    public ManiaPubResource(string projectName, string contact, string? apiKey = null) : base(projectName, contact, apiKey)
    {
    }

    /// <summary>
    /// Get a info list of in-game ManiaPubs.
    /// </summary>
    /// <returns></returns>
    public Task<TmIoAd[]?> GetManiaPubsAsync() =>
        WithApiKey()
            .GetJsonAsync<TmIoAd[]>("/ads");
}