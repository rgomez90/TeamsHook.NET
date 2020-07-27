using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TeamsHook.NET
{
    public abstract class TeamsCard
    {
        protected TeamsCard(CardType cardType)
        {
            CardType = cardType;
            Context = "http://schema.org/extensions";
        }

        [JsonPropertyName("@type")]
        [JsonProperty("@type")]
        public CardType CardType { get; private set; }

        [JsonPropertyName("@context")]
        [JsonProperty("@context")]
        public string Context { get; private set; }
    }
}