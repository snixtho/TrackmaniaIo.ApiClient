using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TrackmaniaIo.ApiClient.Models.Matchmaking;

public class TmIoMatchmakingInfo
{
    public string? AccountId { get; set; }
    public int Progression { get; set; }
    public long Rank { get; set; }
    public int Score { get; set; }
    public int TypeId { get; set; }
    public string? TypeName { get; set; }
    
    public Dictionary<string, JsonElement>? Division { get; set; }
    [JsonPropertyName("division_next")]
    public Dictionary<string, JsonElement>? DivisionNext { get; set; }

    /// <summary>
    /// Convert the internal Division properties to objects rather than dictionaries.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public TmIoMatchmakingInfo<T> ToObject<T>() where T : TmIoDivision
    {
        var info = new TmIoMatchmakingInfo<T>
        {
            Division = Activator.CreateInstance<T>(),
            DivisionNext = Activator.CreateInstance<T>(),
            AccountId = AccountId,
            Progression = Progression,
            Rank = Rank,
            Score = Score,
            TypeId = TypeId,
            TypeName = TypeName
        };

        var type = typeof(T);

        if (Division != null)
            foreach (var (key, value) in Division)
            {
                var property = type.GetProperty(key,
                    BindingFlags.Instance | BindingFlags.IgnoreCase | BindingFlags.Public);
                
                if (property == null)
                    continue;
                
                property.SetValue(info.Division, value.Deserialize(property.PropertyType));
            }

        if (DivisionNext != null)
            foreach (var (key, value) in DivisionNext)
            {
                var property = type.GetProperty(key,
                    BindingFlags.Instance | BindingFlags.IgnoreCase | BindingFlags.Public);
                
                if (property == null)
                    continue;
                
                property.SetValue(info.DivisionNext, value.Deserialize(property.PropertyType));
            }

        return info;
    }
}

public class TmIoMatchmakingInfo<T> : TmIoMatchmakingInfo
{
    public new T? Division { get; set; }
    [JsonPropertyName("division_next")]
    public new T? DivisionNext { get; set; }
}