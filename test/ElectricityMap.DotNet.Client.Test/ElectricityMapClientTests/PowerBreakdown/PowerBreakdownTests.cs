using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.History;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using System;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.PowerBreakdown
{
    public class PowerBreakdownTests
    {
        [Fact]
        public async void Get_power_breakdown_live_zone()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClient = testFactory.SetupLivePowerBreakdownMocksWithZone();

            string zone = "DK-DK1";

            LivePowerBreakdown response = await electricityClient.GetLivePowerBreakdownAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_live_lat_long()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClient = testFactory.SetupLivePowerBreakdownMocksWithLatLong();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;

            LivePowerBreakdown response = await electricityClient.GetLivePowerBreakdownAsync(latitude, longitude);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_recent_zone()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClient = testFactory.SetupRecentPowerBreakdownMocksWithZone();

            string zone = "DK-DK1";

            RecentPowerBreakdownHistory response = await electricityClient.GetRecentPowerBreakdownHistoryAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_recent_lat_long()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClient = testFactory.SetupRecentPowerBreakdownMocksWithLatLong();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;

            RecentPowerBreakdownHistory response = await electricityClient.GetRecentPowerBreakdownHistoryAsync(latitude, longitude);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_history_zone()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClient = testFactory.SetupPastPowerBreakdownMocksWithZone();

            string zone = "DK-DK1";
            DateTime datetime = DateTime.Now;

            PastPowerBreakdownHistory response = await electricityClient.GetPastPowerBreakdownHistoryAsync(zone, datetime);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_history_lat_long()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClient = testFactory.SetupPastPowerBreakdownMocksWithLatLong();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            DateTime datetime = DateTime.Now;

            PastPowerBreakdownHistory response = await electricityClient.GetPastPowerBreakdownHistoryAsync(latitude, longitude, datetime);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_forecast_zone()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClient = testFactory.SetupForecastPowerBreakdownMocksWithZone();

            string zone = "DK-DK1";

            ForecastedPowerConsumptionBreakdown response = await electricityClient.GetForecastedPowerConsumptionBreakdownAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_forecast_lat_long()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClient = testFactory.SetupForecastPowerBreakdownMocksWithLatLong();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;

            ForecastedPowerConsumptionBreakdown response = await electricityClient.GetForecastedPowerConsumptionBreakdownAsync(latitude, longitude);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_marginal_forecast_zone()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClient = testFactory.SetupMarginalForecastPowerBreakdownMocksWithZone();

            string zone = "DK-DK1";

            ForecastedMarginalPowerConsumptionBreakdown response = await electricityClient.GetForecastedMarginalPowerConsumptionBreakdownAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_marginal_forecast_lat_long()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClient = testFactory.SetupMarginalForecastPowerBreakdownMocksWithLatLong();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;

            ForecastedMarginalPowerConsumptionBreakdown response = await electricityClient.GetForecastedMarginalPowerConsumptionBreakdownAsync(latitude, longitude);

            Assert.NotNull(response);
        }
    }
}