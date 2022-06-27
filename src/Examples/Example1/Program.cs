using TrackmaniaIo.ApiClient;

var tmio = new TmIoApi("Tm.io .NET Api Client", "Discord snixtho#9039");

var totd = await tmio.Totd.GetTotdAsync();

Console.WriteLine("TOTD map name: " + totd.Name);
