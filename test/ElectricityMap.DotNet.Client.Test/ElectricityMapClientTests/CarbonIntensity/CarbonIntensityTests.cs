using AutoFixture.Xunit2;
using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.History;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using FluentAssertions;
using NSubstitute;
using System;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.CarbonIntensity
{
    public class CarbonIntensityTests
    {
        private readonly IElectricityMapClient sut;

        public CarbonIntensityTests()
        {
            sut = Substitute.For<IElectricityMapClient>();
        }

        [Theory, AutoData]
        public async void Get_carbon_intensity_live_zone(
            string zone,
            LiveCarbonIntensity data)
        {
            sut
                .GetLiveCarbonIntensityAsync(Arg.Any<string>())
                .Returns(data);

            var result = await sut
                 .GetLiveCarbonIntensityAsync(zone);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory, AutoData]
        public async void Get_carbon_intensity_live_lat_long(
            double latitude,
            double longitude,
            LiveCarbonIntensity data)
        {
            sut
                .GetLiveCarbonIntensityAsync(Arg.Any<double>(), Arg.Any<double>())
                .Returns(data);

            var result = await sut
                 .GetLiveCarbonIntensityAsync(latitude, longitude);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory, AutoData]
        public async void Get_carbon_intensity_recent_zone(
            string zone,
            RecentCarbonIntensityHistory data)
        {
            sut
                .GetRecentCarbonIntensityHistoryAsync(Arg.Any<string>())
                .Returns(data);

            var result = await sut
                 .GetRecentCarbonIntensityHistoryAsync(zone);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory, AutoData]
        public async void Get_carbon_intensity_recent_lat_long(
            double latitude,
            double longitude,
            RecentCarbonIntensityHistory data)
        {
            sut
                .GetRecentCarbonIntensityHistoryAsync(Arg.Any<double>(), Arg.Any<double>())
                .Returns(data);

            var result = await sut
                 .GetRecentCarbonIntensityHistoryAsync(latitude, longitude);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory, AutoData]
        public async void Get_carbon_intensity_past_zone(
            string zone,
            DateTime date,
            PastCarbonIntensityHistory data)
        {
            sut
                .GetPastCarbonIntensityHistoryAsync(Arg.Any<string>(), Arg.Any<DateTime>())
                .Returns(data);

            var result = await sut
                 .GetPastCarbonIntensityHistoryAsync(zone, date);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory, AutoData]
        public async void Get_carbon_intensity_past_lat_long(
            double latitude,
            double longitude,
            DateTime date,
            PastCarbonIntensityHistory data)
        {
            sut
                .GetPastCarbonIntensityHistoryAsync(Arg.Any<double>(), Arg.Any<double>(), Arg.Any<DateTime>())
                .Returns(data);

            var result = await sut
                 .GetPastCarbonIntensityHistoryAsync(latitude, longitude, date);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory, AutoData]
        public async void Get_carbon_intensity_forecast_zone(
            string zone,
            ForecastedCarbonIntensity data)
        {
            sut
                .GetForecastedCarbonIntensityAsync(Arg.Any<string>())
                .Returns(data);

            var result = await sut
                 .GetForecastedCarbonIntensityAsync(zone);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory, AutoData]
        public async void Get_carbon_intensity_forecast_lat_long(
            double latitude,
            double longitude,
            ForecastedCarbonIntensity data)
        {
            sut
                .GetForecastedCarbonIntensityAsync(Arg.Any<double>(), Arg.Any<double>())
                .Returns(data);

            var result = await sut
                 .GetForecastedCarbonIntensityAsync(latitude, longitude);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory, AutoData]
        public async void Get_carbon_intensity_marginal_forecast_zone(
           string zone,
           ForecastedMarginalCarbonIntensity data)
        {
            sut
                .GetForecastedMarginalCarbonIntensityAsync(Arg.Any<string>())
                .Returns(data);

            var result = await sut
                 .GetForecastedMarginalCarbonIntensityAsync(zone);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }

        [Theory, AutoData]
        public async void Get_carbon_intensity_marginal_forecast_lat_long(
            double latitude,
            double longitude,
            ForecastedMarginalCarbonIntensity data)
        {
            sut
                .GetForecastedMarginalCarbonIntensityAsync(Arg.Any<double>(), Arg.Any<double>())
                .Returns(data);

            var result = await sut
                 .GetForecastedMarginalCarbonIntensityAsync(latitude, longitude);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }
    }
}