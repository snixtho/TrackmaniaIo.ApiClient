using TrackmaniaIo.ApiClient.Resources;

namespace TrackmaniaIo.ApiClient;

public class TmIoApi
{
    public TotdResourceApi Totd { get; private set; }

    public TmIoApi(string projectName, string contact) => Initialize(projectName, contact);
    public TmIoApi(string projectName, string contact, string? apiKey=null) => Initialize(projectName, contact, apiKey);

    private void Initialize(string projectName, string contact, string? apiKey=null)
    {
        Totd = new TotdResourceApi(projectName, contact, apiKey);
    }
}