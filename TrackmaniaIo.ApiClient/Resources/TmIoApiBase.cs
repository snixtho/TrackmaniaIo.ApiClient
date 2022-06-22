using Hawf.Attributes;
using Hawf.Client;

namespace TrackmaniaIo.ApiClient.Resources;

[ApiClient("https://trackmania.io/api")]
public abstract class TmIoApiBase<T> : ApiBase<T> where T : TmIoApiBase<T>
{
    private readonly string? _apiKey;

    protected TmIoApiBase(string? apiKey=null)
    {
        _apiKey = apiKey;
        
        Configure(options =>
        {
            // avoid tm.io rate limits
            options.UseRateLimit = true;
            options.RateLimitTimespan = TimeSpan.FromMinutes(1);
            options.RateLimitMaxRequests = apiKey == null ? 40 : 150;

            // cache everything by default for 1 minute
            options.CacheResponse = true;
            options.DefaultCacheTime = TimeSpan.FromMinutes(1);
        });
    }
}