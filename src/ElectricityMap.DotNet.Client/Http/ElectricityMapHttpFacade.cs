using ElectricityMap.DotNet.Client.Constants;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityMap.DotNet.Client.Http
{
    internal sealed class ElectricityMapHttpFacade
    {
        private readonly HttpClient _httpClient;
        private readonly ElectricityMapApiRequestor _requestor;

        public ElectricityMapHttpFacade(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
                throw new ArgumentNullException(apiKey, "You must pass a valid API key to access the Electricity Map.");

            _httpClient.BaseAddress = new Uri(ApiConstants.BaseUrl);
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add(ApiConstants.AuthHeader, apiKey);
        }

        public Task<T> Get<T>(string uri) =>
            _requestor.Get<T>(uri);
    }
}
