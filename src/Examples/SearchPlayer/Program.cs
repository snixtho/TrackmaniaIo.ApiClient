using TrackmaniaIo.ApiClient;

var tmio = new TmIoApi("Tm.io .NET Api Client", "Discord snixtho#9039");

var search = await tmio.Players.SearchPlayersAsync("snix");

Console.WriteLine("players found: ");
foreach (var player in search)
{
    Console.WriteLine(player.Player.Name);
}
