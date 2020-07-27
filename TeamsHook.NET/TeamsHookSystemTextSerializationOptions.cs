using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace TeamsHook.NET
{
    public static class TeamsHookSystemTextSerializationOptions
    {
        private static JsonSerializerOptions _instance;

        public static JsonSerializerOptions Instance =>
            _instance ?? (_instance = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
                WriteIndented = true,
                Converters = {new JsonStringEnumConverter()},
            });
    }

    public class TeamsNewtonsoftSerializationOptions : JsonSerializerSettings
    {
        public TeamsNewtonsoftSerializationOptions()
        {
            NullValueHandling = NullValueHandling.Ignore;
            ContractResolver = new CamelCasePropertyNamesContractResolver();
            Converters = new List<JsonConverter>() {new StringEnumConverter()};
        }
    }
}