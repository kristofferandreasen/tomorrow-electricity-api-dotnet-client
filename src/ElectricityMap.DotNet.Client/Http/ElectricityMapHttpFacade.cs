using ElectricityMap.DotNet.Client.Constants;
using ElectricityMap.DotNet.Client.Exceptions;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ElectricityMap.DotNet.Client.Http
{
    public class ElectricityMapHttpFacade : IElectricityMapHttpFacade
    {
        private readonly HttpClient httpClient;

        public ElectricityMapHttpFacade(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentNullException(apiKey, "You must pass a valid API key to access the Electricity Map.");
            }

            httpClient = new HttpClient
            {
                BaseAddress = new Uri(ApiConstants.BaseUrl)
            };
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add(ApiConstants.AuthHeader, apiKey);
        }

        public async Task<T> GetAsync<T>(string url)
        {
            HttpResponseMessage responseMessage = await httpClient
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