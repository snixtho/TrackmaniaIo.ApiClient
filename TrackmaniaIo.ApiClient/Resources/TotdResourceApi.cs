using Hawf.Client;

namespace TrackmaniaIo.ApiClient.Resources;

public class TotdResourceApi : TmIoApiBase<TotdResourceApi>
{
    public TotdResourceApi(string projectName, string contact, string? apiKey = null) : base(projectName, contact, apiKey)
    {
    }
    
    
}