using ElectricityMap.DotNet.Client.Exceptions;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ElectricityMap.DotNet.Client.Http
{
    /// <summary>
    /// Simplifies the requests for all
    /// endpoints in the API to make one way of
    /// handling requests and responses.
    /// </summary>
    internal sealed class ElectricityMapApiRequestor
    {
        private readonly HttpClient client;

        public ElectricityMapApiRequestor(HttpClient client)
        {
            this.client = client;
        }

        public async Task<T> GetAsync<T>(string url)
        {
            HttpResponseMessage responseMessage = await client
                .GetAsync(url).ConfigureAwait(false);

            await EnsureSuccessStatusCodeAsync(responseMessage)
                .ConfigureAwait(false);

            return await ReadResponseAsync<T>(responseMessage)
                .ConfigureAwait(false);
        }

        private static async Task<T> ReadResponseAsync<T>(HttpResponseMessage responseMessage)
        {
            string response = await responseMessage.Content
                .ReadAsStringAsync()
                .ConfigureAwait(false);

            var result = JsonConvert.DeserializeObject<T>(response);

            return result;
        }

        private static async Task EnsureSuccessStatusCodeAsync(HttpResponseMessage responseMessage)
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                return;
            }

            string errorResponse = await responseMessage.Content
                .ReadAsStringAsync()
                .ConfigureAwait(false);

            throw new ElectricityMapException(responseMessage.StatusCode, errorResponse ?? string.Empty);
        }
    }
}