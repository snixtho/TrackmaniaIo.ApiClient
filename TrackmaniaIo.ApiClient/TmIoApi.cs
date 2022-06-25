using TrackmaniaIo.ApiClient.Resources;

namespace TrackmaniaIo.ApiClient;

public class TmIoApi
{
    /// <summary>
    /// Track of the Day
    /// </summary>
    public TotdResourceApi Totd { get; private set; }
    /// <summary>
    /// Cup of the day
    /// </summary>
    public CotdResourceApi Cotd { get; private set; }
    /// <summary>
    /// Uploaded maps
    /// </summary>
    public MapsResourceApi Maps { get; private set; }
    /// <summary>
    /// Campaigns, maps & general leaderboards
    /// </summary>
    public LeaderboardResourceApi Leaderboards { get; private set; }
    /// <summary>
    /// Events and competitions
    /// </summary>
    public CompetitionResource Competitions { get; private set; }
    /// <summary>
    /// Online rooms and servers
    /// </summary>
    public RoomsResource Rooms { get; private set; }
    /// <summary>
    /// Club campaigns
    /// </summary>
    public CampaignsResource Campaigns { get; private set; }
    /// <summary>
    /// Club resources
    /// </summary>
    public ClubsResource Clubs { get; private set; }
    /// <summary>
    /// Player rankings
    /// </summary>
    public TopPlayersResource TopPlayers { get; private set; }
    /// <summary>
    /// Player lists, info and search
    /// </summary>
    public PlayersResource Players { get; private set; }
    /// <summary>
    /// In-game player generated advertisement
    /// </summary>
    public ManiaPubResource ManiaPubs { get; private set; }

    public TmIoApi(string projectName, string contact) => Initialize(projectName, contact);
    public TmIoApi(string projectName, string contact, string? apiKey=null) => Initialize(projectName, contact, apiKey);

    private void Initialize(string projectName, string contact, string? apiKey=null)
    {
        Totd = new TotdResourceApi(projectName, contact, this, apiKey);
        Cotd = new CotdResourceApi(projectName, contact, apiKey);
        Maps = new MapsResourceApi(projectName, contact, apiKey);
        Leaderboards = new LeaderboardResourceApi(projectName, contact, apiKey);
        Competitions = new CompetitionResource(projectName, contact, apiKey);
        Rooms = new RoomsResource(projectName, contact, apiKey);
        Campaigns = new CampaignsResource(projectName, contact, apiKey);
        Clubs = new ClubsResource(projectName, contact, apiKey);
        TopPlayers = new TopPlayersResource(projectName, contact, apiKey);
        Players = new PlayersResource(projectName, contact, apiKey);
        ManiaPubs = new ManiaPubResource(projectName, contact, apiKey);
    }
}
