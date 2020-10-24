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
            IElectricityMapClient electricityClientZone = testFactory.SetupLivePowerBreakdownMocksWithZone();

            string zone = "DK-DK1";

            LivePowerBreakdown response = await electricityClientZone.GetLivePowerBreakdownAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_live_lat_long()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClientZone = testFactory.SetupLivePowerBreakdownMocksWithLatLong();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;

            LivePowerBreakdown response = await electricityClientZone.GetLivePowerBreakdownAsync(latitude, longitude);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_recent_zone()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClientZone = testFactory.SetupRecentPowerBreakdownMocksWithZone();

            string zone = "DK-DK1";

            RecentPowerBreakdownHistory response = await electricityClientZone.GetRecentPowerBreakdownHistoryAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_recent_lat_long()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClientZone = testFactory.SetupRecentPowerBreakdownMocksWithLatLong();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;

            RecentPowerBreakdownHistory response = await electricityClientZone.GetRecentPowerBreakdownHistoryAsync(latitude, longitude);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_history_zone()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClientZone = testFactory.SetupPastPowerBreakdownMocksWithZone();

            string zone = "DK-DK1";
            DateTime datetime = DateTime.Now;

            PastPowerBreakdownHistory response = await electricityClientZone.GetPastPowerBreakdownHistoryAsync(zone, datetime);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_history_lat_long()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClientZone = testFactory.SetupPastPowerBreakdownMocksWithLatLong();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            DateTime datetime = DateTime.Now;

            PastPowerBreakdownHistory response = await electricityClientZone.GetPastPowerBreakdownHistoryAsync(latitude, longitude, datetime);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_forecast_zone()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClientZone = testFactory.SetupForecastPowerBreakdownMocksWithZone();

            string zone = "DK-DK1";

            ForecastedPowerConsumptionBreakdown response = await electricityClientZone.GetForecastedPowerConsumptionBreakdownAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_forecast_lat_long()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClientZone = testFactory.SetupForecastPowerBreakdownMocksWithLatLong();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;

            ForecastedPowerConsumptionBreakdown response = await electricityClientZone.GetForecastedPowerConsumptionBreakdownAsync(latitude, longitude);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_marginal_forecast_zone()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClientZone = testFactory.SetupMarginalForecastPowerBreakdownMocksWithZone();

            string zone = "DK-DK1";

            ForecastedMarginalPowerConsumptionBreakdown response = await electricityClientZone.GetForecastedMarginalPowerConsumptionBreakdownAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_power_breakdown_marginal_forecast_lat_long()
        {
            var testFactory = new PowerBreakdownTestFactory();
            IElectricityMapClient electricityClientZone = testFactory.SetupMarginalForecastPowerBreakdownMocksWithLatLong();

            double latitude = 55.6590875d;
            double longitude = 12.5492117d;

            ForecastedMarginalPowerConsumptionBreakdown response = await electricityClientZone.GetForecastedMarginalPowerConsumptionBreakdownAsync(latitude, longitude);

            Assert.NotNull(response);
        }
    }
}