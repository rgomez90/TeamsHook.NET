using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TeamsHook.NET
{
    public class TeamsHookClient
    {
        private readonly HttpClient _client;

        public TeamsHookClient(HttpClient client = null)
        {
            _client = client ?? new HttpClient();
        }

        public Task<HttpResponseMessage> PostAsync(string webhookUrl, TeamsCard card)
        {
            var payload = JsonConvert.SerializeObject(card, new TeamsNewtonsoftSerializationOptions());
            return _client.PostAsync(webhookUrl, new StringContent(payload, Encoding.UTF8, "application/json"));
        }
    }
}