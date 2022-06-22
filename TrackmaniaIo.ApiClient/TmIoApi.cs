using TrackmaniaIo.ApiClient.Resources;

namespace TrackmaniaIo.ApiClient;

public class TmIoApi
{
    public TotdResourceApi Totd { get; private set; }
    public CotdResourceApi Cotd { get; private set; }
    public MapsResourceApi Maps { get; private set; }
    public LeaderboardResourceApi Leaderboards { get; private set; }
    public CompetitionResource Competitions { get; private set; }

    public TmIoApi(string projectName, string contact) => Initialize(projectName, contact);
    public TmIoApi(string projectName, string contact, string? apiKey=null) => Initialize(projectName, contact, apiKey);

    private void Initialize(string projectName, string contact, string? apiKey=null)
    {
        Totd = new TotdResourceApi(projectName, contact, this, apiKey);
        Cotd = new CotdResourceApi(projectName, contact, apiKey);
        Maps = new MapsResourceApi(projectName, contact, apiKey);
        Leaderboards = new LeaderboardResourceApi(projectName, contact, apiKey);
        Competitions = new CompetitionResource(projectName, contact, apiKey);
    }
}
