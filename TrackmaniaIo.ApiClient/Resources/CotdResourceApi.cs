using TrackmaniaIo.ApiClient.Models;

namespace TrackmaniaIo.ApiClient.Resources;

public class CotdResourceApi : TmIoApiBase<CotdResourceApi>
{
    public CotdResourceApi(string projectName, string contact, string? apiKey = null) : base(projectName, contact, apiKey)
    {
    }

    /// <summary>
    /// Get a list of latest COTD competitions.
    /// </summary>
    /// <param name="offset">Offset from latest COTD to get the list from</param>
    /// <returns></returns>
    public Task<TmIoCompetitionList?> GetCotdListAsync(int offset = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoCompetitionList>("/cotd/{offset}", offset);

    /// <summary>
    /// Get the wins leaderboard.
    /// </summary>
    /// <param name="offset">Offset from position 0</param>
    /// <returns></returns>
    public Task<TmIoCotdLeaderboard?> GetWinsLeaderboardAsync(bool includeReruns = false, int offset = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoCotdLeaderboard>("/cotd/players/{offset}/wins{reruns}", offset, includeReruns ? "reruns" : "");

    /// <summary>
    /// Get the win-streak leaderboard.
    /// </summary>
    /// <param name="offset">Offset from position 0</param>
    /// <returns></returns>
    public Task<TmIoCotdLeaderboard?> GetWinStreakLeaderboardAsync(bool includeReruns = false, int offset = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoCotdLeaderboard>("/cotd/players/{offset}/winstreak{reruns}", offset, includeReruns ? "reruns" : "");

    /// <summary>
    /// Get the total played leaderboard.
    /// </summary>
    /// <param name="offset">Offset from position 0</param>
    /// <returns></returns>
    public Task<TmIoCotdLeaderboard?> GetTotalPlayedLeaderboardAsync(bool includeReruns = false, int offset = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoCotdLeaderboard>("/cotd/players/{offset}/totalplayed{reruns}", offset, includeReruns ? "reruns" : "");
}
