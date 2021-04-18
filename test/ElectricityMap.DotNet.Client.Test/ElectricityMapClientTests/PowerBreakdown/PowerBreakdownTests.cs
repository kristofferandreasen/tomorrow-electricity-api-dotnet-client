using System;
using System.Threading.Tasks;
using AutoFixture.Xunit2;
using ElectricityMap.DotNet.Client.Http;
using ElectricityMap.DotNet.Client.Models.Breakdown;
using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.PowerBreakdown
{
    public class PowerBreakdownTests
    {
        private readonly IElectricityMapHttpFacade httpFacade;
        private readonly ElectricityMapClient sut;

        public PowerBreakdownTests()
        {
            httpFacade = Substitute.For<IElectricityMapHttpFacade>();
            sut = new ElectricityMapClient(httpFacade);
        }

        [Theory]
        [AutoData]
        public async Task Get_power_breakdown_live_zone_Async(
            string zone,
            LivePowerBreakdown livePowerBreakdown)
        {
            httpFacade
                .GetAsync<LivePowerBreakdown>(Arg.Any<Uri>())
                .Returns(livePowerBreakdown);

            var result = await sut
                 .GetLivePowerBreakdownAsync(zone)
                 .ConfigureAwait(false);

            result.Should().NotBeNull();
            result.Should().Be(livePowerBreakdown);
        }

        [Theory]
        [AutoData]
        public async Task Get_power_breakdown_live_lat_long_Async(
            double latitude,
            double longitude,
            LivePowerBreakdown livePowerBreakdown)
        {
            httpFacade
                .GetAsync<LivePowerBreakdown>(Arg.Any<Uri>())
                .Returns(livePowerBreakdown);

            var result = await sut
                 .GetLivePowerBreakdownAsync(latitude, longitude)
                 .ConfigureAwait(false);

            result.Should().NotBeNull();
            result.Should().Be(livePowerBreakdown);
        }

        [Theory]
        [AutoData]
        public async Task Get_power_breakdown_recent_zone_Async(
            string zone,
            RecentPowerBreakdownHistory recentPowerBreakdown)
        {
            httpFacade
                .GetAsync<RecentPowerBreakdownHistory>(Arg.Any<Uri>())
                .Returns(recentPowerBreakdown);

            var result = await sut
                 .GetRecentPowerBreakdownHistoryAsync(zone)
                 .ConfigureAwait(false);

            result.Should().NotBeNull();
            result.Should().Be(recentPowerBreakdown);
        }

        [Theory]
        [AutoData]
        public async Task Get_power_breakdown_recent_lat_long_Async(
            double latitude,
            double longitude,
            RecentPowerBreakdownHistory recentPowerBreakdown)
        {
            httpFacade
                .GetAsync<RecentPowerBreakdownHistory>(Arg.Any<Uri>())
                .Returns(recentPowerBreakdown);

            var result = await sut
                 .GetRecentPowerBreakdownHistoryAsync(latitude, longitude)
                 .ConfigureAwait(false);

            result.Should().NotBeNull();
            result.Should().Be(recentPowerBreakdown);
        }

        [Theory]
        [AutoData]
        public async Task Get_power_breakdown_history_zone_Async(
            string zone,
            DateTime date,
            PastPowerBreakdownHistory pastPowerBreakdown)
        {
            httpFacade
                .GetAsync<PastPowerBreakdownHistory>(Arg.Any<Uri>())
                .Returns(pastPowerBreakdown);

            var result = await sut
                 .GetPastPowerBreakdownHistoryAsync(zone, date)
                 .ConfigureAwait(false);

            result.Should().NotBeNull();
            result.Should().Be(pastPowerBreakdown);
        }

        [Theory]
        [AutoData]
        public async Task Get_power_breakdown_history_lat_long_Async(
            double latitude,
            double longitude,
            DateTime date,
            PastPowerBreakdownHistory pastPowerBreakdown)
        {
            httpFacade
                .GetAsync<PastPowerBreakdownHistory>(Arg.Any<Uri>())
                .Returns(pastPowerBreakdown);

            var result = await sut
                 .GetPastPowerBreakdownHistoryAsync(latitude, longitude, date)
                 .ConfigureAwait(false);

            result.Should().NotBeNull();
            result.Should().Be(pastPowerBreakdown);
        }

        [Theory]
        [AutoData]
        public async Task Get_power_breakdown_forecast_zone_Async(
            string zone,
            ForecastedPowerConsumptionBreakdown data)
        {
            httpFacade
                .GetAsync<ForecastedPowerConsumptionBreakdown>(Arg.Any<Uri>())
                .Returns(data);

            var result = await sut
                 .GetForecastedPowerConsumptionBreakdownAsync(zone)
                 .ConfigureAwait(false);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory]
        [AutoData]
        public async Task Get_power_breakdown_forecast_lat_long_Async(
            double latitude,
            double longitude,
            ForecastedPowerConsumptionBreakdown data)
        {
            httpFacade
                .GetAsync<ForecastedPowerConsumptionBreakdown>(Arg.Any<Uri>())
                .Returns(data);

            var result = await sut
                 .GetForecastedPowerConsumptionBreakdownAsync(latitude, longitude)
                 .ConfigureAwait(false);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory]
        [AutoData]
        public async Task Get_power_breakdown_marginal_forecast_zone_Async(
            string zone,
            ForecastedMarginalPowerConsumptionBreakdown data)
        {
            httpFacade
                .GetAsync<ForecastedMarginalPowerConsumptionBreakdown>(Arg.Any<Uri>())
                .Returns(data);

            var result = await sut
                 .GetForecastedMarginalPowerConsumptionBreakdownAsync(zone)
                 .ConfigureAwait(false);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory]
        [AutoData]
        public async Task Get_power_breakdown_marginal_forecast_lat_long_Async(
            double latitude,
            double longitude,
            ForecastedMarginalPowerConsumptionBreakdown data)
        {
            httpFacade
                .GetAsync<ForecastedMarginalPowerConsumptionBreakdown>(Arg.Any<Uri>())
                .Returns(data);

            var result = await sut
                 .GetForecastedMarginalPowerConsumptionBreakdownAsync(latitude, longitude)
                 .ConfigureAwait(false);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }
    }
}
