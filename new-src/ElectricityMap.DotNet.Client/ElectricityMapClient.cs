using ElectricityMap.DotNet.Client.Constants;
using ElectricityMap.DotNet.Client.Helpers;
using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models;
using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.History;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using ElectricityMap.DotNet.Client.Models.Updates;
using ElectricityMap.DotNet.Client.Models.Zones;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ElectricityMap.DotNet.Client
{
    public class ElectricityMapClient : IElectricityMapClient
    {
        public readonly HttpClient httpClient = new HttpClient();

        public ElectricityMapClient(string apiKey)
        {
            httpClient.BaseAddress = new Uri(ApiConstants.BaseUrl);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("auth-token", apiKey);
        }

        public async Task<Zones> GetZonesAsync()
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiConstants.Zones);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            Zones zones = JsonConvert.DeserializeObject<Zones>(responseString);

            return zones;
        }

        public async Task<ForecastedCarbonIntensity> GetForecastedCarbonIntensityAsync(string zone, double? longitude, double? latitude)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiConstants.CarbonIntensity, ApiConstants.Forecast);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            ForecastedCarbonIntensity carbonIntensity = JsonConvert.DeserializeObject<ForecastedCarbonIntensity>(responseString);

            return carbonIntensity;
        }

        public async Task<ForecastedMarginalCarbonIntensity> GetForecastedMarginalCarbonIntensityAsync(string zone, double? longitude, double? latitude)
        {
            throw new NotImplementedException();
        }

        public async Task<ForecastedMarginalPowerConsumptionBreakdown> GetForecastedMarginalPowerConsumptionBreakdownAsync(string zone, double? longitude, double? latitude)
        {
            throw new NotImplementedException();
        }

        public async Task<ForecastedPowerConsumptionBreakdown> GetForecastedPowerConsumptionBreakdownAsync(string zone, double? longitude, double? latitude)
        {
            throw new NotImplementedException();
        }

        public async Task<LiveCarbonIntensity> GetLiveCarbonIntensityAsync(string zone, double? longitude, double? latitude)
        {
            throw new NotImplementedException();
        }

        public async Task<LivePowerBreakdown> GetLivePowerBreakdownAsync(string zone, double? longitude, double? latitude)
        {
            throw new NotImplementedException();
        }

        public async Task<PastCarbonIntensityHistory> GetPastCarbonIntensityHistoryAsync(string zone, double? longitude, double? latitude, DateTime datetime)
        {
            throw new NotImplementedException();
        }

        public async Task<PastPowerBreakdownHistory> GetPastPowerBreakdownHistoryAsync(string zone, double? longitude, double? latitude, DateTime datetime)
        {
            throw new NotImplementedException();
        }

        public async Task<RecentCarbonIntensityHistory> GetRecentCarbonIntensityHistoryAsync(string zone, double? longitude, double? latitude)
        {
            throw new NotImplementedException();
        }

        public async Task<RecentPowerBreakdownHistory> GetRecentPowerBreakdownHistoryAsync(string zone, double? longitude, double? latitude)
        {
            throw new NotImplementedException();
        }

        public async Task<UpdatedSince> GetUpdateInfoAsync(UpdatedSinceRequest updatedSinceRequest)
        {
            throw new NotImplementedException();
        }
    }
}