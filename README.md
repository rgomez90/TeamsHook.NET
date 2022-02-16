[![Build and publish on version change](https://github.com/rgomez90/TeamsHook.NET/actions/workflows/dotnet.yml/badge.svg)](https://github.com/rgomez90/TeamsHook.NET/actions/workflows/dotnet.yml) [![Nuget](https://img.shields.io/nuget/dt/TeamsHook.NET?label=NuGet&logo=nuget)](https://www.nuget.org/packages/TeamsHook.NET/)

# TeamsHook.NET

### A .NET client for posting messages to Microsoft Teams via webhooks

[Teams Legacy MessageCard Reference](https://docs.microsoft.com/en-us/outlook/actionable-messages/message-card-reference#actions)

[Teams Webhooks Docs](https://docs.microsoft.com/en-us/microsoftteams/platform/webhooks-and-connectors/how-to/connectors-using)

## Installation

You can install the latest release by installing the package from [NuGet](https://www.nuget.org/packages/TeamsHook.NET/) using `Install-Package TeamsHook.NET`.

Alternatively, clone/fork this repo and compile the source yourself.

## Usage

Just create a new `TeamsHookClient`

```csharp
var client = new TeamsHookClient();
```

Create your card 

```csharp
var card = new MessageCard()
{
    //CardOptions
}
```

Post your message

```csharp
await client.PostAsync("https://your-teams-webhook", card)
```

## Contributing

Everyone is welcome, who wants to contribute to this repo! Just open an issue with your intention or make a comment in some open issue you would like to work on.
