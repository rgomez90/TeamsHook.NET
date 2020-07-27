using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TeamsHook.NET
{
    public abstract class MessageAction
    {
        protected MessageAction(MessageActionType type)
        {
            Type = type;
        }

        [JsonPropertyName("@type")]
        [JsonProperty("@type")]
        public MessageActionType Type { get; private set; }
    }
}