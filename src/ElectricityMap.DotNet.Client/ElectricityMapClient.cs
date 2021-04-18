using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElectricityMap.DotNet.Client.Constants;
using ElectricityMap.DotNet.Client.Helpers;
using ElectricityMap.DotNet.Client.Http;
using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models;
using ElectricityMap.DotNet.Client.Models.Breakdown;
using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.History;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using ElectricityMap.DotNet.Client.Models.Updates;
using ElectricityMap.DotNet.Client.Models.Zones;

namespace ElectricityMap.DotNet.Client
{
    public class ElectricityMapClient : IElectricityMapClient
    {
        private readonly IElectricityMapHttpFacade httpFacade;

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricityMapClient"/> class.
        /// </summary>
        /// <param name="httpFacade"></param>
        public ElectricityMapClient(IElectricityMapHttpFacade httpFacade)
        {
            this.httpFacade = httpFacade;
        }

        public Task<Dictionary<string, ZoneData>> GetAvailableZonesAsync()
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.Zones);

            return httpFacade
                .GetAsync<Dictionary<string, ZoneData>>(requestUrl);
        }

        public Task<LiveCarbonIntensity> GetLiveCarbonIntensityAsync(string zone)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.Latest, zone);

            return httpFacade
                .GetAsync<LiveCarbonIntensity>(requestUrl);
        }

        public Task<LiveCarbonIntensity> GetLiveCarbonIntensityAsync(double latitude, double longitude)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.Latest, latitude, longitude);

            return httpFacade
                .GetAsync<LiveCarbonIntensity>(requestUrl);
        }

        public Task<LivePowerBreakdown> GetLivePowerBreakdownAsync(string zone)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.Latest, zone);

            return httpFacade
                .GetAsync<LivePowerBreakdown>(requestUrl);
        }

        public Task<LivePowerBreakdown> GetLivePowerBreakdownAsync(double latitude, double longitude)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.Latest, latitude, longitude);

            return httpFacade
                .GetAsync<LivePowerBreakdown>(requestUrl);
        }

        public Task<RecentCarbonIntensityHistory> GetRecentCarbonIntensityHistoryAsync(string zone)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.History, zone);

            return httpFacade
                .GetAsync<RecentCarbonIntensityHistory>(requestUrl);
        }

        public Task<RecentCarbonIntensityHistory> GetRecentCarbonIntensityHistoryAsync(double latitude, double longitude)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.History, latitude, longitude);

            return httpFacade
                .GetAsync<RecentCarbonIntensityHistory>(requestUrl);
        }

        public Task<RecentPowerBreakdownHistory> GetRecentPowerBreakdownHistoryAsync(string zone)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.History, zone);

            return httpFacade
                .GetAsync<RecentPowerBreakdownHistory>(requestUrl);
        }

        public Task<RecentPowerBreakdownHistory> GetRecentPowerBreakdownHistoryAsync(double latitude, double longitude)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.History, latitude, longitude);

            return httpFacade
                .GetAsync<RecentPowerBreakdownHistory>(requestUrl);
        }

        public Task<PastCarbonIntensityHistory> GetPastCarbonIntensityHistoryAsync(string zone, DateTime datetime)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.Past, zone, datetime);

            return httpFacade
                .GetAsync<PastCarbonIntensityHistory>(requestUrl);
        }

        public Task<PastCarbonIntensityHistory> GetPastCarbonIntensityHistoryAsync(double latitude, double longitude, DateTime datetime)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.Past, latitude, longitude, datetime);

            return httpFacade
                .GetAsync<PastCarbonIntensityHistory>(requestUrl);
        }

        public Task<PastPowerBreakdownHistory> GetPastPowerBreakdownHistoryAsync(string zone, DateTime datetime)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.Past, zone, datetime);

            return httpFacade
                .GetAsync<PastPowerBreakdownHistory>(requestUrl);
        }

        public Task<PastPowerBreakdownHistory> GetPastPowerBreakdownHistoryAsync(
            double latitude,
            double longitude,
            DateTime datetime)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.Past, latitude, longitude, datetime);

            return httpFacade.GetAsync<PastPowerBreakdownHistory>(requestUrl);
        }

        public Task<ForecastedCarbonIntensity> GetForecastedCarbonIntensityAsync(string zone)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.Forecast, zone);

            return httpFacade
                .GetAsync<ForecastedCarbonIntensity>(requestUrl);
        }

        public Task<ForecastedCarbonIntensity> GetForecastedCarbonIntensityAsync(
            double latitude,
            double longitude)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.CarbonIntensity, ApiActions.Forecast, latitude, longitude);

            return httpFacade
                .GetAsync<ForecastedCarbonIntensity>(requestUrl);
        }

        public Task<ForecastedPowerConsumptionBreakdown> GetForecastedPowerConsumptionBreakdownAsync(string zone)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.Forecast, zone);

            return httpFacade
                .GetAsync<ForecastedPowerConsumptionBreakdown>(requestUrl);
        }

        public Task<ForecastedPowerConsumptionBreakdown> GetForecastedPowerConsumptionBreakdownAsync(
            double latitude,
            double longitude)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.PowerConsumptionBreakdown, ApiActions.Forecast, latitude, longitude);

            return httpFacade
                .GetAsync<ForecastedPowerConsumptionBreakdown>(requestUrl);
        }

        public Task<ForecastedMarginalCarbonIntensity> GetForecastedMarginalCarbonIntensityAsync(string zone)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.MarginalCarbonIntensity, ApiActions.Forecast, zone);

            return httpFacade
                .GetAsync<ForecastedMarginalCarbonIntensity>(requestUrl);
        }

        public Task<ForecastedMarginalCarbonIntensity> GetForecastedMarginalCarbonIntensityAsync(
            double latitude,
            double longitude)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.MarginalCarbonIntensity, ApiActions.Forecast, latitude, longitude);

            return httpFacade
                .GetAsync<ForecastedMarginalCarbonIntensity>(requestUrl);
        }

        public Task<ForecastedMarginalPowerConsumptionBreakdown> GetForecastedMarginalPowerConsumptionBreakdownAsync(string zone)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.MarginalPowerConsumptionBreakdown, ApiActions.Forecast, zone);

            return httpFacade
                .GetAsync<ForecastedMarginalPowerConsumptionBreakdown>(requestUrl);
        }

        public Task<ForecastedMarginalPowerConsumptionBreakdown> GetForecastedMarginalPowerConsumptionBreakdownAsync(double latitude, double longitude)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(ApiAreas.MarginalPowerConsumptionBreakdown, ApiActions.Forecast, latitude, longitude);

            return httpFacade
                .GetAsync<ForecastedMarginalPowerConsumptionBreakdown>(requestUrl);
        }

        public Task<UpdatedSince> GetUpdateInfoAsync(UpdatedSinceRequest updatedSinceRequest)
        {
            var requestUrl = RequestUrlHelpers
                .ConstructRequest(updatedSinceRequest);

            return httpFacade
                .GetAsync<UpdatedSince>(requestUrl);
        }
    }
}
