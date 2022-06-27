using TrackmaniaIo.ApiClient;

var tmio = new TmIoApi("Tm.io .NET Api Client Example", "<your contact>");

var totd = await tmio.Totd.GetTotdAsync();

Console.WriteLine("TOTD map name: " + totd.Name);
