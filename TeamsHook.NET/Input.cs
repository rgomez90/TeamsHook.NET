using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TeamsHook.NET
{
    public abstract class Input
    {
        protected Input(MessageInputType type)
        {
            Type = type;
        }

        public string Id { get; set; }
        public bool IsRequired { get; set; }
        public string Title { get; set; }
        [JsonPropertyName("@type")]
        [JsonProperty("@type")]
        public MessageInputType Type { get; }
        public string Value { get; set; }
    }
}