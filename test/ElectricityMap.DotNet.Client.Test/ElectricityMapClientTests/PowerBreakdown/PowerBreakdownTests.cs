using AutoFixture.Xunit2;
using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Breakdown;
using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using FluentAssertions;
using NSubstitute;
using System;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.PowerBreakdown
{
    public class PowerBreakdownTests
    {
        private readonly IElectricityMapClient sut;

        public PowerBreakdownTests()
        {
            sut = Substitute.For<IElectricityMapClient>();
        }

        [Theory, AutoData]
        public async void Get_power_breakdown_live_zone(
            string zone,
            LivePowerBreakdown livePowerBreakdown)
        {
            sut
                .GetLivePowerBreakdownAsync(Arg.Any<string>())
                .Returns(livePowerBreakdown);

            var result = await sut
                 .GetLivePowerBreakdownAsync(zone);

            result.Should().NotBeNull();
            result.Should().Be(livePowerBreakdown);
        }

        [Theory, AutoData]
        public async void Get_power_breakdown_live_lat_long(
            double latitude,
            double longitude,
            LivePowerBreakdown livePowerBreakdown)
        {
            sut
                .GetLivePowerBreakdownAsync(Arg.Any<double>(), Arg.Any<double>())
                .Returns(livePowerBreakdown);

            var result = await sut
                 .GetLivePowerBreakdownAsync(latitude, longitude);

            result.Should().NotBeNull();
            result.Should().Be(livePowerBreakdown);
        }

        [Theory, AutoData]
        public async void Get_power_breakdown_recent_zone(
            string zone,
            RecentPowerBreakdownHistory recentPowerBreakdown)
        {
            sut
                .GetRecentPowerBreakdownHistoryAsync(Arg.Any<string>())
                .Returns(recentPowerBreakdown);

            var result = await sut
                 .GetRecentPowerBreakdownHistoryAsync(zone);

            result.Should().NotBeNull();
            result.Should().Be(recentPowerBreakdown);
        }

        [Theory, AutoData]
        public async void Get_power_breakdown_recent_lat_long(
            double latitude,
            double longitude,
            RecentPowerBreakdownHistory recentPowerBreakdown)
        {
            sut
                .GetRecentPowerBreakdownHistoryAsync(Arg.Any<double>(), Arg.Any<double>())
                .Returns(recentPowerBreakdown);

            var result = await sut
                 .GetRecentPowerBreakdownHistoryAsync(latitude, longitude);

            result.Should().NotBeNull();
            result.Should().Be(recentPowerBreakdown);
        }

        [Theory, AutoData]
        public async void Get_power_breakdown_history_zone(
            string zone,
            DateTime date,
            PastPowerBreakdownHistory pastPowerBreakdown)
        {
            sut
                .GetPastPowerBreakdownHistoryAsync(Arg.Any<string>(), Arg.Any<DateTime>())
                .Returns(pastPowerBreakdown);

            var result = await sut
                 .GetPastPowerBreakdownHistoryAsync(zone, date);

            result.Should().NotBeNull();
            result.Should().Be(pastPowerBreakdown);
        }

        [Theory, AutoData]
        public async void Get_power_breakdown_history_lat_long(
            double latitude,
            double longitude,
            DateTime date,
            PastPowerBreakdownHistory pastPowerBreakdown)
        {
            sut
                .GetPastPowerBreakdownHistoryAsync(Arg.Any<double>(), Arg.Any<double>(), Arg.Any<DateTime>())
                .Returns(pastPowerBreakdown);

            var result = await sut
                 .GetPastPowerBreakdownHistoryAsync(latitude, longitude, date);

            result.Should().NotBeNull();
            result.Should().Be(pastPowerBreakdown);
        }

        [Theory, AutoData]
        public async void Get_power_breakdown_forecast_zone(
            string zone,
            ForecastedPowerConsumptionBreakdown data)
        {
            sut
                .GetForecastedPowerConsumptionBreakdownAsync(Arg.Any<string>())
                .Returns(data);

            var result = await sut
                 .GetForecastedPowerConsumptionBreakdownAsync(zone);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory, AutoData]
        public async void Get_power_breakdown_forecast_lat_long(
            double latitude,
            double longitude,
            ForecastedPowerConsumptionBreakdown data)
        {
            sut
                .GetForecastedPowerConsumptionBreakdownAsync(Arg.Any<double>(), Arg.Any<double>())
                .Returns(data);

            var result = await sut
                 .GetForecastedPowerConsumptionBreakdownAsync(latitude, longitude);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory, AutoData]
        public async void Get_power_breakdown_marginal_forecast_zone(
            string zone,
            ForecastedMarginalPowerConsumptionBreakdown data)
        {
            sut
                .GetForecastedMarginalPowerConsumptionBreakdownAsync(Arg.Any<string>())
                .Returns(data);

            var result = await sut
                 .GetForecastedMarginalPowerConsumptionBreakdownAsync(zone);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory, AutoData]
        public async void Get_power_breakdown_marginal_forecast_lat_long(
            double latitude,
            double longitude,
            ForecastedMarginalPowerConsumptionBreakdown data)
        {
            sut
                .GetForecastedMarginalPowerConsumptionBreakdownAsync(Arg.Any<double>(), Arg.Any<double>())
                .Returns(data);

            var result = await sut
                 .GetForecastedMarginalPowerConsumptionBreakdownAsync(latitude, longitude);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }
    }
}