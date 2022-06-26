using TrackmaniaIo.ApiClient.Models.Campaigns;

namespace TrackmaniaIo.ApiClient.Resources;

/// <summary>
/// Club campaigns
/// </summary>
public class CampaignsResource : TmIoApiBase<CampaignsResource>
{
    public CampaignsResource(string projectName, string contact, string? apiKey = null) : base(projectName, contact, apiKey)
    {
    }

    /// <summary>
    /// Get a list of campaigns.
    /// </summary>
    /// <param name="page">Pagination number.</param>
    /// <returns></returns>
    public Task<TmIoCampaignList?> GetCampaignListAsync(int page = 0) =>
        WithApiKey()
            .GetJsonAsync<TmIoCampaignList>("/campaigns/{page}", page);

    /// <summary>
    /// Get info about a campaign.
    /// </summary>
    /// <param name="clubId">ID of the club the campaign is in</param>
    /// <param name="id">Id of the campaign</param>
    /// <returns></returns>
    public Task<TmIoCampaignInfo?> GetCampaignInfoAsync(int clubId, long id) =>
        WithApiKey()
            .GetJsonAsync<TmIoCampaignInfo>("/campaign/{clubId}/{id}", clubId, id);
}