using TrackmaniaIo.ApiClient;
using TrackmaniaIo.ApiClient.Models;

var tmio = new TmIoApi("Tm.io .NET Api Client", "Discord snixtho#9039");

var totd = await tmio.Players.GetPlayerProfileAsync("7cd60a75-609a-4e64-b286-16f329878249");

var obj = totd.Matchmaking.First().Info.ToObject<TmIoMmDivision>();

Console.WriteLine(totd);