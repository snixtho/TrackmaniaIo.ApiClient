using TrackmaniaIo.ApiClient.Models.Clubs;
using TrackmaniaIo.ApiClient.Models.Enums;

namespace TrackmaniaIo.ApiClient.Resources;

/// <summary>
/// Club resources
/// </summary>
public class ClubsResource : TmIoApiBase<ClubsResource>
{
    public ClubsResource(string projectName, string contact, string? apiKey = null) : base(projectName, contact, apiKey)
    {
    }

    /// <summary>
    /// Get a list of clubs.
    /// </summary>
    /// <param name="page">Pagination number</param>
    /// <param name="sorting">What to sort the clubs for.</param>
    /// <param name="sortDirection">If sorting is "name" you can chose the sorting order here.</param>
    /// <returns></returns>
    public Task<TmIoClubList?> GetClubsAsync(int page = 0, string sorting = TmIoClubSorting.Popularity,
        string? sortDirection = null) =>
        WithApiKey()
            .WithQueryParam("sort", sorting)
            .WithQueryParam("order", sortDirection)
            .GetJsonAsync<TmIoClubList>("/clubs/{page}", page);

    /// <summary>
    /// Get info about a club
    /// </summary>
    /// <param name="id">ID of the club</param>
    /// <returns></returns>
    public Task<TmIoClubInfo?> GetClubAsync(int id) =>
        WithApiKey()
            .GetJsonAsync<TmIoClubInfo>("/club/{id}", id);

    /// <summary>
    /// Get list of members of a club
    /// </summary>
    /// <param name="id">ID of the club</param>
    /// <param name="page">Pagination number</param>
    /// <returns></returns>
    public Task<TmIoClubMemberList?> GetMembersAsync(int id, int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoClubMemberList>("/club/{id}/members/{page}", id, page);

    /// <summary>
    /// Get a list of activities in a club
    /// </summary>
    /// <param name="id">ID of the club</param>
    /// <param name="page">Pagination number</param>
    /// <returns></returns>
    public Task<TmIoClubActivityList?> GetActivitiesAsync(int id, int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoClubActivityList>("/club/{id}/members/{page}");

}