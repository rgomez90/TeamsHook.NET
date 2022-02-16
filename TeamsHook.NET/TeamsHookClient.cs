using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TeamsHook.NET
{
    public class TeamsHookClient
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _jsonSettings;

        public TeamsHookClient(HttpClient client = null)
        {
            _client = client ?? new HttpClient();
            _jsonSettings = TeamsHookJsonSettings.Default();
        }

        public Task<HttpResponseMessage> PostAsync(string webhookUrl, TeamsCard card)
        {
            var payload = JsonSerializer.Serialize(card, _jsonSettings);
            return _client.PostAsync(webhookUrl, new StringContent(payload, Encoding.UTF8, "application/json"));
        }
    }
}