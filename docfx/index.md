# TrackmaniaIo.ApiClient Documentation

## Installation
The library can be found on [Nuget](https://www.nuget.org/packages/TrackmaniaIo.ApiClient) and can be installed with the dotnet CLI tool:
```
dotnet add package TrackmaniaIo.ApiClient
```

## Getting Started
To start using the client, create and instance of the `TmIoApi` class. To respect Trackmania.io's API usage guidelines and rules, please provide a unique name of your program as well as a way for Miss to contact you.

For example:
```cs
var tmio = new TmIoApi("My Cool Program", "my@email.com");
```

Using the API is quite simple. Everything is organized into their respective resources. For example to get the current Track Of The Day map information, call the `GetTotdAsync` method in the Totd resource:
```
var totd = await tmio.Totd.GetTotdAsync();

// do something with the map information
```

## Caching & Rate limiting
By default all requests are cached for 1 minute and without an API key, rate limit is triggered at 40 requests per minute. If the rate limit is hit, an exception is thrown.

## Examples
Some examples on the usage of the client can be found [here](https://github.com/snixtho/TrackmaniaIo.ApiClient/tree/master/src/Examples).

## Api Docs
You can find a list of available resources and their methods [here](/api/TrackmaniaIo.ApiClient.Resources.html).
