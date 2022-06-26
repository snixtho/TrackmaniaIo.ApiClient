using TrackmaniaIo.ApiClient.Models.Maps;
using TrackmaniaIo.ApiClient.Models.Totd;

namespace TrackmaniaIo.ApiClient.Resources;

/// <summary>
/// Track of the Day
/// </summary>
public class TotdResource : TmIoApiBase<TotdResource>
{
    private readonly TmIoApi _tmIoApi;
    
    public TotdResource(string projectName, string contact, TmIoApi tmIoApi, string? apiKey = null) : base(projectName, contact, apiKey)
    {
        _tmIoApi = tmIoApi;
    }

    /// <summary>
    /// Get a month's list of TOTDs.
    /// </summary>
    /// <param name="offset">Month offset from current month.</param>
    /// <returns></returns>
    public Task<TmIoTotdMonth?> GetMonthAsync(int offset = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoTotdMonth>("/totd/{offset}", offset);

    /// <summary>
    /// Get the identifiers for the current TOTD.
    /// </summary>
    /// <returns></returns>
    public Task<TmIoMapId?> GetTodayMapIdAsync() =>
        WithApiKey()
            .GetJsonAsync<TmIoMapId>("/totd/today");

    /// <summary>
    /// Get map info of current TOTD.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException">
    /// Throws if TOTD map ids failed to be retrieved
    /// </exception>
    public async Task<TmIoMapInfo?> GetTotdAsync()
    {
        var todayId = await GetTodayMapIdAsync();

        if (todayId == null)
            throw new InvalidOperationException("Failed to get ID of today's TOTD");

        if (todayId.Uid == null)
            throw new InvalidOperationException("Failed to get the UID of map, cannot continue.");

        return await _tmIoApi.Maps.GetMapAsync(todayId.Uid);
    }
}