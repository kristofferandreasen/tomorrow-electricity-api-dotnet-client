using AutoFixture.Xunit2;
using ElectricityMap.DotNet.Client.Http;
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
        private readonly IElectricityMapHttpFacade httpFacade;
        private readonly ElectricityMapClient sut;

        public CarbonIntensityTests()
        {
            httpFacade = Substitute.For<IElectricityMapHttpFacade>();
            sut = new ElectricityMapClient(httpFacade);
        }

        [Theory, AutoData]
        public async void Get_carbon_intensity_live_zone(
            string zone,
            LiveCarbonIntensity data)
        {
            httpFacade
                .GetAsync<LiveCarbonIntensity>(Arg.Any<Uri>())
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
            httpFacade
                .GetAsync<LiveCarbonIntensity>(Arg.Any<Uri>())
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
            httpFacade
                .GetAsync<RecentCarbonIntensityHistory>(Arg.Any<Uri>())
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
            httpFacade
                .GetAsync<RecentCarbonIntensityHistory>(Arg.Any<Uri>())
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
            httpFacade
                .GetAsync<PastCarbonIntensityHistory>(Arg.Any<Uri>())
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
            httpFacade
                .GetAsync<PastCarbonIntensityHistory>(Arg.Any<Uri>())
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
            httpFacade
                .GetAsync<ForecastedCarbonIntensity>(Arg.Any<Uri>())
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
            httpFacade
                .GetAsync<ForecastedCarbonIntensity>(Arg.Any<Uri>())
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
            httpFacade
                .GetAsync<ForecastedMarginalCarbonIntensity>(Arg.Any<Uri>())
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
            httpFacade
                .GetAsync<ForecastedMarginalCarbonIntensity>(Arg.Any<Uri>())
                .Returns(data);

            var result = await sut
                 .GetForecastedMarginalCarbonIntensityAsync(latitude, longitude);

            result.Should().NotBeNull();
            result.Should().Be(data);
        }
    }
}
