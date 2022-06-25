using System.Text.Json.Serialization;

namespace TrackmaniaIo.ApiClient.Models;

public class TmIoMatchmakingInfo
{
    public string? AccountId { get; set; }
    public int Progression { get; set; }
    public long Rank { get; set; }
    public int Score { get; set; }
    public int TypeId { get; set; }
    public string? TypeName { get; set; }
    
    public Dictionary<string, object>? Division { get; set; }
    [JsonPropertyName("division_next")]
    public Dictionary<string, object>? DivisionNext { get; set; }

    /// <summary>
    /// Convert the internal Division properties to objects rather than dictionaries.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public TmIoMatchmakingInfo<T> ConvertToObject<T>()
    {
        var info = new TmIoMatchmakingInfo<T>
        {
            Division = Activator.CreateInstance<T>(),
            DivisionNext = Activator.CreateInstance<T>()
        };

        var type = typeof(T);

        if (Division != null)
            foreach (var (key, value) in Division)
                type.GetProperty(key)?.SetValue(info.Division, value, null);

        if (DivisionNext != null)
            foreach (var (key, value) in DivisionNext)
                type.GetProperty(key)?.SetValue(info.DivisionNext, value, null);

        return info;
    }
}

public class TmIoMatchmakingInfo<T> : TmIoMatchmakingInfo
{
    public new T? Division { get; set; }
    [JsonPropertyName("division_next")]
    public new T? DivisionNext { get; set; }
}