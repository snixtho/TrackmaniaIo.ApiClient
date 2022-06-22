using System.Web;
using Hawf.Attributes;
using Hawf.Client;

namespace TrackmaniaIo.ApiClient.Resources;

[ApiClient("https://trackmania.io/api")]
public abstract class TmIoApiBase<T> : ApiBase<T> where T : TmIoApiBase<T>
{
    private readonly string? _apiKey;

    protected TmIoApiBase(string projectName, string contact, string? apiKey=null)
    {
        _apiKey = apiKey;
        
        Configure(options =>
        {
            options.DefaultUserAgent = HttpUtility.UrlEncode($"Project {projectName}; Contact {contact}");
            
            // avoid tm.io rate limits
            options.UseRateLimit = true;
            options.RateLimitTimespan = TimeSpan.FromMinutes(1);
            options.RateLimitMaxRequests = apiKey == null ? 40 : 150;

            // cache everything by default for 1 minute
            options.CacheResponse = true;
            options.DefaultCacheTime = TimeSpan.FromMinutes(1);
        });
    }

    protected T WithApiKey()
    {
        if (_apiKey != null)
            WithBearerToken(_apiKey);
        return (T) this;
    }
}