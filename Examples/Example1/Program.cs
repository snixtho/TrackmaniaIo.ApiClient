using TrackmaniaIo.ApiClient;
using TrackmaniaIo.ApiClient.Models;

var tmio = new TmIoApi("Tm.io .NET Api Client", "Discord snixtho#9039");

var totd = await tmio.ManiaPubs.GetManiaPubsAsync();

Console.WriteLine(totd);