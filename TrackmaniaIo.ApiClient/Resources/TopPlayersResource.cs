using TrackmaniaIo.ApiClient.Models;

namespace TrackmaniaIo.ApiClient.Resources;

public class TopPlayersResource : TmIoApiBase<TopPlayersResource>
{
    public TopPlayersResource(string projectName, string contact, string? apiKey = null) : base(projectName, contact, apiKey)
    {
    }

    public Task<TmIoPlayerRankList<TmIoTropyRankPosition>?> GetTopByTrophiesAsync(int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerRankList<TmIoTropyRankPosition>>("/top/trophies/{page}", page);

    public Task<TmIoPlayerRankList<TmIoMmPosition>?> GetTopBy3V3Async(int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerRankList<TmIoMmPosition>>("/top/matchmaking/2/{page}", page);
    
    public Task<TmIoPlayerRankList<TmIoMmPosition>?> GetTopByRoyalAsync(int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerRankList<TmIoMmPosition>>("/top/matchmaking/3/{page}", page); 
}