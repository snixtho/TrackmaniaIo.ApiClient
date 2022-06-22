using TrackmaniaIo.ApiClient;

var tmio = new TmIoApi("Tm.io .NET Api Client", "Discord snixtho#9039");

var totd = await tmio.Competitions.GetChallengeResultsAsync(2857, 1422);

Console.WriteLine(totd);