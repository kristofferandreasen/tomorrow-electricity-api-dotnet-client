using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.History;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using System;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.CarbonIntensity
{
    public class CarbonIntensityTests
    {
        private IElectricityMapClient electricityClient;
        private CarbonIntensityTestFactory testFactory = new CarbonIntensityTestFactory();

        [Fact]
        public async void Get_carbon_intensity_live_zone()
        {
            electricityClient = testFactory.SetupLiveCarbonIntensityMocksWithZone();

            string zone = "DK-DK1";

            LiveCarbonIntensity response = await electricityClient.GetLiveCarbonIntensityAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_live_lat_long()
        {
            electricityClient = testFactory.SetupLiveCarbonIntensityMocksWithLatitudeLongitude();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            LiveCarbonIntensity response = await electricityClient.GetLiveCarbonIntensityAsync(latitude, longitude);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_recent_zone()
        {
            electricityClient = testFactory.SetupRecentCarbonIntensityMocksWithZone();

            string zone = "DK-DK1";

            RecentCarbonIntensityHistory response = await electricityClient.GetRecentCarbonIntensityHistoryAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_recent_lat_long()
        {
            electricityClient = testFactory.SetupRecentCarbonIntensityMocksWithLatitudeLongitude();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            RecentCarbonIntensityHistory response = await electricityClient.GetRecentCarbonIntensityHistoryAsync(latitude, longitude);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_past_zone()
        {
            electricityClient = testFactory.SetupPastCarbonIntensityMocksWithZone();

            string zone = "DK-DK1";
            DateTime datetime = DateTime.Now;

            PastCarbonIntensityHistory response = await electricityClient.GetPastCarbonIntensityHistoryAsync(zone, datetime);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_past_lat_long()
        {
            electricityClient = testFactory.SetupPastCarbonIntensityMocksWithLatitudeLongitude();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            DateTime datetime = DateTime.Now;

            PastCarbonIntensityHistory response = await electricityClient.GetPastCarbonIntensityHistoryAsync(latitude, longitude, datetime);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_forecast_zone()
        {
            electricityClient = testFactory.SetupForecastedCarbonIntensityMocksWithZone();

            string zone = "DK-DK1";

            ForecastedCarbonIntensity response = await electricityClient.GetForecastedCarbonIntensityAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_forecast_lat_long()
        {
            electricityClient = testFactory.SetupForecastedCarbonIntensityMocksWithLatitudeLongitude();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;

            ForecastedCarbonIntensity response = await electricityClient.GetForecastedCarbonIntensityAsync(latitude, longitude);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_marginal_forecast_zone()
        {
            electricityClient = testFactory.SetupForecastedMarginalCarbonIntensityMocksWithZone();

            string zone = "DK-DK1";

            ForecastedMarginalCarbonIntensity response = await electricityClient.GetForecastedMarginalCarbonIntensityAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_marginal_forecast_lat_long()
        {
            electricityClient = testFactory.SetupForecastedMarginalCarbonIntensityMocksWithLatitudeLongitude();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;

            ForecastedMarginalCarbonIntensity response = await electricityClient.GetForecastedMarginalCarbonIntensityAsync(latitude, longitude);

            Assert.NotNull(response);
        }
    }
}