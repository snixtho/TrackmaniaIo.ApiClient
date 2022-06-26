using TrackmaniaIo.ApiClient.Models.Matchmaking;
using TrackmaniaIo.ApiClient.Models.Players;

namespace TrackmaniaIo.ApiClient.Resources;

/// <summary>
/// General player rankings
/// </summary>
public class TopPlayersResource : TmIoApiBase<TopPlayersResource>
{
    public TopPlayersResource(string projectName, string contact, string? apiKey = null) : base(projectName, contact, apiKey)
    {
    }

    /// <summary>
    /// Get player rankings based on trophies.
    /// </summary>
    /// <param name="page">Pagination number</param>
    /// <returns></returns>
    public Task<TmIoPlayerRankList<TmIoTropyRankPosition>?> GetTopByTrophiesAsync(int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerRankList<TmIoTropyRankPosition>>("/top/trophies/{page}", page);

    /// <summary>
    /// Get player rankings based on 3v3 matchmaking.
    /// </summary>
    /// <param name="page">Pagination number</param>
    /// <returns></returns>
    public Task<TmIoPlayerRankList<TmIoMmPosition>?> GetTopBy3V3Async(int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerRankList<TmIoMmPosition>>("/top/matchmaking/2/{page}", page);
    
    /// <summary>
    /// Get player rankings based on royal.
    /// </summary>
    /// <param name="page">Pagination number</param>
    /// <returns></returns>
    public Task<TmIoPlayerRankList<TmIoMmPosition>?> GetTopByRoyalAsync(int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerRankList<TmIoMmPosition>>("/top/matchmaking/3/{page}", page); 
}
