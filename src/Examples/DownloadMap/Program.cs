﻿using TrackmaniaIo.ApiClient;

var tmio = new TmIoApi("Tm.io .NET Api Client Example", "<your contact>");

var map = await tmio.Maps.GetMapAsync("djXt5m4K7voTJvjFgWSCyIlESgf");
var mapStream = await tmio.Maps.DownloadMapAsync(map);

using var file = File.Create(map.FileName);
mapStream.CopyTo(file);
