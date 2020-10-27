using ElectricityMap.DotNet.Client.Exceptions;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ElectricityMap.DotNet.Client.Http
{
    internal sealed class ElectricityMapApiRequestor
    {
        private readonly HttpClient _client;

        public ElectricityMapApiRequestor(HttpClient client)
        {
            _client = client;
        }

        public async Task<T> Get<T>(string url)
        {
            HttpResponseMessage responseMessage = await _client.GetAsync(url);
            await EnsureSuccessStatusCode(responseMessage);

            return await ReadResponse<T>(responseMessage);
        }

        private async Task<T> ReadResponse<T>(HttpResponseMessage responseMessage)
        {
            string response = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(response);

            return result;
        }

        private static async Task EnsureSuccessStatusCode(HttpResponseMessage responseMessage)
        {
            if (responseMessage.IsSuccessStatusCode)
                return;

            string errorResponse = await responseMessage.Content.ReadAsStringAsync();
            throw new ElectricityMapException(responseMessage.StatusCode, errorResponse ?? "");
        }
    }
}