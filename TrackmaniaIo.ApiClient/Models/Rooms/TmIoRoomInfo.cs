using TrackmaniaIo.ApiClient.Models.Maps;

namespace TrackmaniaIo.ApiClient.Models.Rooms;

public class TmIoRoomInfo
{
    public int ClubId { get; set; }
    public long Id { get; set; }
    public IEnumerable<TmIoMapInfo>? Maps { get; set; }
    public string? MediaUrl { get; set; }
    public bool Nadeo { get; set; }
    public string? Name { get; set; }
    public int PlayerCount { get; set; }
    public int PlayerMax { get; set; }
    public string? Region { get; set; }
    public string? Script { get; set; }
    public Dictionary<string, TmIoScriptSettingOption>? ScriptSettings { get; set; }
}