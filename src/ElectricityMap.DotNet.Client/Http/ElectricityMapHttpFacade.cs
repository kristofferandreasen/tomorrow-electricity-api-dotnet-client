using ElectricityMap.DotNet.Client.Constants;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ElectricityMap.DotNet.Client.Http
{
    public class ElectricityMapHttpFacade
    {
        private readonly ElectricityMapApiRequestor _requestor;

        public ElectricityMapHttpFacade(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
                throw new ArgumentNullException(apiKey, "You must pass a valid API key to access the Electricity Map.");

            HttpClient _httpClient = new HttpClient
            {
                BaseAddress = new Uri(ApiConstants.BaseUrl)
            };
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add(ApiConstants.AuthHeader, apiKey);
            _requestor = new ElectricityMapApiRequestor(_httpClient);
        }

        public Task<T> Get<T>(string uri) =>
            _requestor.Get<T>(uri);
    }
}