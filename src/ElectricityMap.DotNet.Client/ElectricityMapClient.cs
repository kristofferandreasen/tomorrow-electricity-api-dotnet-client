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

        public ElectricityMapClient()
        {
            httpClient.BaseAddress = new Uri(ApiConstants.BaseUrl);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public ElectricityMapClient(string apiKey)
        {
            httpClient.BaseAddress = new Uri(ApiConstants.BaseUrl);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("auth-token", apiKey);
        }

        public async Task<Zones> GetZonesAsync()
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.Zones);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            Zones data = JsonConvert.DeserializeObject<Zones>(responseString);

            return data;
        }

        public async Task<LiveCarbonIntensity> GetLiveCarbonIntensityAsync(string zone)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.Latest, zone);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            LiveCarbonIntensity data = JsonConvert.DeserializeObject<LiveCarbonIntensity>(responseString);

            return data;
        }

        public async Task<LiveCarbonIntensity> GetLiveCarbonIntensityAsync(double latitude, double longitude)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.Latest, latitude, longitude);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            LiveCarbonIntensity data = JsonConvert.DeserializeObject<LiveCarbonIntensity>(responseString);

            return data;
        }

        public async Task<LivePowerBreakdown> GetLivePowerBreakdownAsync(string zone)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.Latest, zone);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            LivePowerBreakdown data = JsonConvert.DeserializeObject<LivePowerBreakdown>(responseString);

            return data;
        }

        public async Task<LivePowerBreakdown> GetLivePowerBreakdownAsync(double latitude, double longitude)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.Latest, latitude, longitude);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            LivePowerBreakdown data = JsonConvert.DeserializeObject<LivePowerBreakdown>(responseString);

            return data;
        }

        public async Task<RecentCarbonIntensityHistory> GetRecentCarbonIntensityHistoryAsync(string zone)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.History, zone);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            RecentCarbonIntensityHistory data = JsonConvert.DeserializeObject<RecentCarbonIntensityHistory>(responseString);

            return data;
        }

        public async Task<RecentCarbonIntensityHistory> GetRecentCarbonIntensityHistoryAsync(double latitude, double longitude)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.History, latitude, longitude);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            RecentCarbonIntensityHistory data = JsonConvert.DeserializeObject<RecentCarbonIntensityHistory>(responseString);

            return data;
        }

        public async Task<RecentPowerBreakdownHistory> GetRecentPowerBreakdownHistoryAsync(string zone)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.History, zone);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            RecentPowerBreakdownHistory data = JsonConvert.DeserializeObject<RecentPowerBreakdownHistory>(responseString);

            return data;
        }

        public async Task<RecentPowerBreakdownHistory> GetRecentPowerBreakdownHistoryAsync(double latitude, double longitude)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.History, latitude, longitude);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            RecentPowerBreakdownHistory data = JsonConvert.DeserializeObject<RecentPowerBreakdownHistory>(responseString);

            return data;
        }

        public async Task<PastCarbonIntensityHistory> GetPastCarbonIntensityHistoryAsync(string zone, DateTime datetime)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.Past, zone, datetime);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            PastCarbonIntensityHistory data = JsonConvert.DeserializeObject<PastCarbonIntensityHistory>(responseString);

            return data;
        }

        public async Task<PastCarbonIntensityHistory> GetPastCarbonIntensityHistoryAsync(double latitude, double longitude, DateTime datetime)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.Past, latitude, longitude, datetime);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            PastCarbonIntensityHistory data = JsonConvert.DeserializeObject<PastCarbonIntensityHistory>(responseString);

            return data;
        }

        public async Task<PastPowerBreakdownHistory> GetPastPowerBreakdownHistoryAsync(string zone, DateTime datetime)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.Past, zone, datetime);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            PastPowerBreakdownHistory data = JsonConvert.DeserializeObject<PastPowerBreakdownHistory>(responseString);

            return data;
        }

        public async Task<PastPowerBreakdownHistory> GetPastPowerBreakdownHistoryAsync(double latitude, double longitude, DateTime datetime)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.Past, latitude, longitude, datetime);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            PastPowerBreakdownHistory data = JsonConvert.DeserializeObject<PastPowerBreakdownHistory>(responseString);

            return data;
        }

        public async Task<ForecastedCarbonIntensity> GetForecastedCarbonIntensityAsync(string zone)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.Forecast, zone);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            ForecastedCarbonIntensity carbonIntensity = JsonConvert.DeserializeObject<ForecastedCarbonIntensity>(responseString);

            return carbonIntensity;
        }

        public async Task<ForecastedCarbonIntensity> GetForecastedCarbonIntensityAsync(double latitude, double longitude)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.Forecast, latitude, longitude);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            ForecastedCarbonIntensity carbonIntensity = JsonConvert.DeserializeObject<ForecastedCarbonIntensity>(responseString);

            return carbonIntensity;
        }

        public async Task<ForecastedPowerConsumptionBreakdown> GetForecastedPowerConsumptionBreakdownAsync(string zone)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.Forecast, zone);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            ForecastedPowerConsumptionBreakdown carbonIntensity = JsonConvert.DeserializeObject<ForecastedPowerConsumptionBreakdown>(responseString);

            return carbonIntensity;
        }

        public async Task<ForecastedPowerConsumptionBreakdown> GetForecastedPowerConsumptionBreakdownAsync(double latitude, double longitude)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.Forecast, latitude, longitude);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            ForecastedPowerConsumptionBreakdown carbonIntensity = JsonConvert.DeserializeObject<ForecastedPowerConsumptionBreakdown>(responseString);

            return carbonIntensity;
        }

        public async Task<ForecastedMarginalCarbonIntensity> GetForecastedMarginalCarbonIntensityAsync(string zone)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.MarginalCarbonIntensity, ApiActions.Forecast, zone);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            ForecastedMarginalCarbonIntensity carbonIntensity = JsonConvert.DeserializeObject<ForecastedMarginalCarbonIntensity>(responseString);

            return carbonIntensity;
        }

        public async Task<ForecastedMarginalCarbonIntensity> GetForecastedMarginalCarbonIntensityAsync(double latitude, double longitude)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.MarginalCarbonIntensity, ApiActions.Forecast, latitude, longitude);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            ForecastedMarginalCarbonIntensity carbonIntensity = JsonConvert.DeserializeObject<ForecastedMarginalCarbonIntensity>(responseString);

            return carbonIntensity;
        }

        public async Task<ForecastedMarginalPowerConsumptionBreakdown> GetForecastedMarginalPowerConsumptionBreakdownAsync(string zone)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.MarginalPowerConsumptionBreakdown, ApiActions.Forecast, zone);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            ForecastedMarginalPowerConsumptionBreakdown carbonIntensity = JsonConvert.DeserializeObject<ForecastedMarginalPowerConsumptionBreakdown>(responseString);

            return carbonIntensity;
        }

        public async Task<ForecastedMarginalPowerConsumptionBreakdown> GetForecastedMarginalPowerConsumptionBreakdownAsync(double latitude, double longitude)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(ApiAreas.MarginalPowerConsumptionBreakdown, ApiActions.Forecast, latitude, longitude);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            ForecastedMarginalPowerConsumptionBreakdown carbonIntensity = JsonConvert.DeserializeObject<ForecastedMarginalPowerConsumptionBreakdown>(responseString);

            return carbonIntensity;
        }

        public async Task<UpdatedSince> GetUpdateInfoAsync(UpdatedSinceRequest updatedSinceRequest)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(updatedSinceRequest);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            UpdatedSince data = JsonConvert.DeserializeObject<UpdatedSince>(responseString);

            return data;
        }
    }
}