using ElectricityMap.DotNet.Client.Constants;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ElectricityMap.DotNet.Client.Http
{
    public class ElectricityMapHttpFacade
    {
        private readonly ElectricityMapApiRequestor requestor;

        public ElectricityMapHttpFacade(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentNullException(apiKey, "You must pass a valid API key to access the Electricity Map.");
            }

            HttpClient httpClient = new HttpClient
            {
                BaseAddress = new Uri(ApiConstants.BaseUrl)
            };
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add(ApiConstants.AuthHeader, apiKey);
            requestor = new ElectricityMapApiRequestor(httpClient);
        }

        public Task<T> GetAsync<T>(string url)
            => requestor.GetAsync<T>(url);
    }
}