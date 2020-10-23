using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.History;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using System;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests
{
    public class CarbonIntensityTests
    {
        private IElectricityMapClient electricityClientZone;
        private IElectricityMapClient electricityClientLatLong;
        private IElectricityMapClient electricityClientRecentHistoryZone;
        private IElectricityMapClient electricityClientRecentHistoryLatLong;
        private IElectricityMapClient electricityClientPastHistoryZone;
        private IElectricityMapClient electricityClientPastHistoryLatLong;
        private IElectricityMapClient electricityClientForecastZone;
        private IElectricityMapClient electricityClientForecastLatLong;
        private IElectricityMapClient electricityClientMarginalForecastZone;
        private IElectricityMapClient electricityClientMarginalForecastLatLong;

        public CarbonIntensityTests()
        {
            var testFactory = new CarbonIntensityTestFactory();
            electricityClientZone = testFactory.SetupLiveCarbonIntensityMocksWithZone();
            electricityClientLatLong = testFactory.SetupLiveCarbonIntensityMocksWithLatitudeLongitude();
            electricityClientRecentHistoryZone = testFactory.SetupRecentCarbonIntensityMocksWithZone();
            electricityClientRecentHistoryLatLong = testFactory.SetupRecentCarbonIntensityMocksWithLatitudeLongitude();
            electricityClientPastHistoryZone = testFactory.SetupPastCarbonIntensityMocksWithZone();
            electricityClientPastHistoryLatLong = testFactory.SetupPastCarbonIntensityMocksWithLatitudeLongitude();
            electricityClientForecastZone = testFactory.SetupForecastedCarbonIntensityMocksWithZone();
            electricityClientForecastLatLong = testFactory.SetupForecastedCarbonIntensityMocksWithLatitudeLongitude();
            electricityClientMarginalForecastZone = testFactory.SetupForecastedMarginalCarbonIntensityMocksWithZone();
            electricityClientMarginalForecastLatLong = testFactory.SetupForecastedMarginalCarbonIntensityMocksWithLatitudeLongitude();
        }

        [Fact]
        public async void Get_carbon_intensity_live_zone()
        {
            string zone = "DK-DK1";

            LiveCarbonIntensity response = await electricityClientZone.GetLiveCarbonIntensityAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_live_lat_long()
        {
            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            LiveCarbonIntensity response = await electricityClientLatLong.GetLiveCarbonIntensityAsync(latitude, longitude);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_recent_zone()
        {
            string zone = "DK-DK1";

            RecentCarbonIntensityHistory response = await electricityClientRecentHistoryZone.GetRecentCarbonIntensityHistoryAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_recent_lat_long()
        {
            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            RecentCarbonIntensityHistory response = await electricityClientRecentHistoryLatLong.GetRecentCarbonIntensityHistoryAsync(latitude, longitude);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_past_zone()
        {
            string zone = "DK-DK1";
            DateTime datetime = DateTime.Now;

            PastCarbonIntensityHistory response = await electricityClientPastHistoryZone.GetPastCarbonIntensityHistoryAsync(zone, datetime);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_past_lat_long()
        {
            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            DateTime datetime = DateTime.Now;

            PastCarbonIntensityHistory response = await electricityClientPastHistoryLatLong.GetPastCarbonIntensityHistoryAsync(latitude, longitude, datetime);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_forecast_zone()
        {
            string zone = "DK-DK1";

            ForecastedCarbonIntensity response = await electricityClientForecastZone.GetForecastedCarbonIntensityAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_forecast_lat_long()
        {
            double latitude = 55.6590875d;
            double longitude = 12.5492117d;

            ForecastedCarbonIntensity response = await electricityClientForecastLatLong.GetForecastedCarbonIntensityAsync(latitude, longitude);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_marginal_forecast_zone()
        {
            string zone = "DK-DK1";

            ForecastedMarginalCarbonIntensity response = await electricityClientMarginalForecastZone.GetForecastedMarginalCarbonIntensityAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_marginal_forecast_lat_long()
        {
            double latitude = 55.6590875d;
            double longitude = 12.5492117d;

            ForecastedMarginalCarbonIntensity response = await electricityClientMarginalForecastLatLong.GetForecastedMarginalCarbonIntensityAsync(latitude, longitude);

            Assert.NotNull(response);
        }
    }
}