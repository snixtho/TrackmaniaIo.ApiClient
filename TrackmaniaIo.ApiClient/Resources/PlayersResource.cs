using TrackmaniaIo.ApiClient.Models.Players;

namespace TrackmaniaIo.ApiClient.Resources;

public class PlayersResource : TmIoApiBase<PlayersResource>
{
    public PlayersResource(string projectName, string contact, string? apiKey = null) : base(projectName, contact, apiKey)
    {
    }

    /// <summary>
    /// Search for players by name.
    /// </summary>
    /// <param name="name">Full or partial name of the player</param>
    /// <returns></returns>
    public Task<TmIoPlayerSearchEntry[]?> SearchPlayersAsync(string name) =>
        WithApiKey()
            .WithQueryParam("search", name)
            .GetJsonAsync<TmIoPlayerSearchEntry[]>("/players/find");

    /// <summary>
    /// Get known Nadeo players.
    /// </summary>
    /// <returns></returns>
    public Task<TmIoPlayerSearchEntry[]?> GetNadeoPlayers() =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerSearchEntry[]>("/players/group/nadeo");

    /// <summary>
    /// Get known TGML players.
    /// </summary>
    /// <returns></returns>
    public Task<TmIoPlayerSearchEntry[]?> GetTmglPlayersAsync() =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerSearchEntry[]>("/players/group/tmgl");

    /// <summary>
    /// Get known players that are sponsors of openplanet and tm.io
    /// </summary>
    /// <returns></returns>
    public Task<TmIoPlayerSearchEntry[]?> GetSponsorPlayersAsync() =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerSearchEntry[]>("/players/group/sponsor");

    /// <summary>
    /// Get known players that are in the team of openplanet and tm.io
    /// </summary>
    /// <returns></returns>
    public Task<TmIoPlayerSearchEntry[]?> GetTmIoTeamPlayersAsync() =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerSearchEntry[]>("/players/group/team");

    /// <summary>
    /// Get the profile of a player
    /// </summary>
    /// <param name="accountId">Account ID of the player (not uid)</param>
    /// <returns></returns>
    public Task<TmIoPlayerProfile?> GetPlayerProfileAsync(string accountId) =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerProfile>("/player/{accountId}", accountId);

    /// <summary>
    /// Get a list of recent 3V3 MM matches.
    /// </summary>
    /// <param name="accountId">Account ID of the player (not uid)</param>
    /// <param name="page">Pagination number</param>
    /// <returns></returns>
    public Task<TmIoPlayerMatchList?> GetPlayer3V3MatchesAsync(string accountId, int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerMatchList>("/player/{accountId}/matches/2/{page}", accountId, page);

    /// <summary>
    /// Get a list of recent royal matches.
    /// </summary>
    /// <param name="accountId">Account ID of the player (not uid)</param>
    /// <param name="page">Pagination number</param>
    /// <returns></returns>
    public Task<TmIoPlayerMatchList?> GetPlayerRoyalMatchesAsync(string accountId, int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerMatchList>("/player/{accountId}/matches/3/{page}", accountId, page);

    /// <summary>
    /// Get a list of recent trophy gains.
    /// </summary>
    /// <param name="accountId">Account ID of the player (not uid)</param>
    /// <param name="page">Pagination number</param>
    /// <returns></returns>
    public Task<TmIoTrophyGainList?> GetPlayerTrophyGainsAsync(string accountId, int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoTrophyGainList>("/player/{accountId}/trophies/{page}", accountId, page);

    /// <summary>
    /// Get information about the player's COTD performances.
    /// </summary>
    /// <param name="accountId">Account ID of the player (not uid)</param>
    /// <param name="page">Pagination number</param>
    /// <returns></returns>
    public Task<TmIoPlayerCotdInfo?> GetPlayerCotdInfoAsync(string accountId, int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoPlayerCotdInfo>("/player/{accountId}/cotd/{page}", accountId, page);
}