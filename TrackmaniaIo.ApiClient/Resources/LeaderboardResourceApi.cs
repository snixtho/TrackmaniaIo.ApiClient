using TrackmaniaIo.ApiClient.Models;

namespace TrackmaniaIo.ApiClient.Resources;

public class LeaderboardResourceApi : TmIoApiBase<LeaderboardResourceApi>
{
    public LeaderboardResourceApi(string projectName, string contact, string? apiKey = null) : base(projectName, contact, apiKey)
    {
    }

    /// <summary>
    /// Get leaderboard positions of a leaderboard group of a certain map.
    /// </summary>
    /// <param name="group">ID of the leaderboard group.</param>
    /// <param name="uid">UID of the map.</param>
    /// <param name="offset">Offset from position 1 in the leaderboard to get records from</param>
    /// <param name="length">Number of records to return.</param>
    /// <returns></returns>
    public Task<TmIoLeaderboardInfo?> GetLeaderboardGroupAsync(string group, string uid, long offset = 0, long length = 15) =>
        WithApiKey()
            .WithQueryParam("offset", offset)
            .WithQueryParam("length", length)
            .GetJsonAsync<TmIoLeaderboardInfo>("/leaderboard/{group}/{uid}", group, uid);
}