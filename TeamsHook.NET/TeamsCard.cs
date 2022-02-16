using System.Text.Json.Serialization;

namespace TeamsHook.NET
{
    public abstract class TeamsCard
    {
        protected TeamsCard(CardType cardType)
        {
            CardType = cardType;
            Context = "http://schema.org/extensions";
        }

        [JsonPropertyName("type")]
        public CardType CardType { get; private set; }

        [JsonPropertyName("context")]
        public string Context { get; private set; }
    }
}