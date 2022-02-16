using System.Text.Json;
using System.Text.Json.Serialization;

namespace TeamsHook.NET;

public static class TeamsHookJsonSettings
{
    public static JsonSerializerOptions Default()
    {
        var settings = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false,
        };
        settings.Converters.Add(new JsonStringEnumConverter());
        return settings;
    }
};