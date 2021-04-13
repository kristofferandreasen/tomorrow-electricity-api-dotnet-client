using AutoFixture.Xunit2;
using ElectricityMap.DotNet.Client.Constants;
using ElectricityMap.DotNet.Client.Models;
using FluentAssertions;
using System;
using Xunit;

namespace ElectricityMap.DotNet.Client.Helpers
{
    public class RequestUrlHelpersTests
    {
        [Theory]
        [InlineData(ApiAreas.Zones)]
        [InlineData(ApiAreas.CarbonIntensity)]
        [InlineData(ApiAreas.PowerConsumptionBreakdown)]
        [InlineData(ApiAreas.MarginalCarbonIntensity)]
        [InlineData(ApiAreas.MarginalPowerConsumptionBreakdown)]
        [InlineData(ApiAreas.UpdatedSince)]
        public void Constructed_area_url_is_correct(
            string area)
        {
            var expectedUrl = $"https://api.electricitymap.org/v3/" +
                $"{area}";

            var requestUrl = RequestUrlHelpers
                .ConstructRequest(area);

            expectedUrl.Should().Be(requestUrl);
        }

        [Theory]
        [InlineData(ApiAreas.CarbonIntensity, ApiActions.Forecast, ZoneConstants.Denmark)]
        [InlineData(ApiAreas.CarbonIntensity, ApiActions.History, ZoneConstants.Namibia)]
        [InlineData(ApiAreas.PowerConsumptionBreakdown, ApiActions.Latest, ZoneConstants.Estonia)]
        [InlineData(ApiAreas.PowerConsumptionBreakdown, ApiActions.Forecast, ZoneConstants.Nepal)]
        [InlineData(ApiAreas.MarginalCarbonIntensity, ApiActions.History, ZoneConstants.Ukraine)]
        [InlineData(ApiAreas.MarginalPowerConsumptionBreakdown, ApiActions.Latest, ZoneConstants.United_States_Alabama)]
        public void Constructed_url_is_correct(
            string area, 
            string action, 
            string zone)
        {
            var expectedUrl = $"https://api.electricitymap.org/v3/" +
                $"{area}{action}" +
                $"?zone={zone}";

            var requestUrl = RequestUrlHelpers
                .ConstructRequest(area, action, zone);

            expectedUrl.Should().Be(requestUrl);
        }

        [Theory]
        [InlineData(ApiAreas.CarbonIntensity, ApiActions.Forecast, ZoneConstants.Denmark)]
        [InlineData(ApiAreas.CarbonIntensity, ApiActions.History, ZoneConstants.Namibia)]
        [InlineData(ApiAreas.PowerConsumptionBreakdown, ApiActions.Latest, ZoneConstants.Estonia)]
        [InlineData(ApiAreas.PowerConsumptionBreakdown, ApiActions.Forecast, ZoneConstants.Nepal)]
        [InlineData(ApiAreas.MarginalCarbonIntensity, ApiActions.History, ZoneConstants.Ukraine)]
        [InlineData(ApiAreas.MarginalPowerConsumptionBreakdown, ApiActions.Latest, ZoneConstants.United_States_Alabama)]
        public void Constructed_url_with_datetime_is_correct(
            string area, 
            string action, 
            string zone)
        {
            var dateTime = DateTime.Now;
            var expectedUrl = $"https://api.electricitymap.org/v3/" +
                $"{area}{action}" +
                $"?zone={zone}" +
                $"&datetime={dateTime:o}";

            var requestUrl = RequestUrlHelpers
                .ConstructRequest(area, action, zone, dateTime);

            expectedUrl.Should().Be(requestUrl);
        }

        [Theory]
        [InlineData(ApiAreas.CarbonIntensity, ApiActions.Forecast, 55.9553455, 9.9264833)]
        [InlineData(ApiAreas.CarbonIntensity, ApiActions.History, 51.4413768, 12.1409151)]
        [InlineData(ApiAreas.PowerConsumptionBreakdown, ApiActions.Latest, 40.5787524, -3.1685326)]
        public void Constructed_url_with_latitude_and_longitude_is_correct(
            string area, 
            string action, 
            double latitude, 
            double longitude)
        {
            var expectedUrl = $"https://api.electricitymap.org/v3/" +
                $"{area}{action}" +
                $"?lat={latitude}" +
                $"&lon={longitude}";

            var requestUrl = RequestUrlHelpers
                .ConstructRequest(area, action, latitude, longitude);

            expectedUrl.Should().Be(requestUrl);
        }

        [Theory]
        [InlineData(ApiAreas.CarbonIntensity, ApiActions.Forecast, 55.9553455, 9.9264833)]
        [InlineData(ApiAreas.CarbonIntensity, ApiActions.History, 51.4413768, 12.1409151)]
        [InlineData(ApiAreas.PowerConsumptionBreakdown, ApiActions.Latest, 40.5787524, -3.1685326)]
        public void Constructed_url_with_latitude_and_longitude_and_datetime_is_correct(
            string area, 
            string action,
            double latitude, 
            double longitude)
        {
            var dateTime = DateTime.Now;

            var expectedUrl = $"https://api.electricitymap.org/v3/" +
                $"{area}{action}" +
                $"?lat={latitude}" +
                $"&lon={longitude}" +
                $"&datetime={dateTime:o}";

            var requestUrl = RequestUrlHelpers
                .ConstructRequest(area, action, latitude, longitude, dateTime);

            expectedUrl.Should().Be(requestUrl);
        }

        [Theory, AutoData]
        public void Constructed_url_with_updated_since_data_is_correct(
            UpdatedSinceRequest updatedSinceRequest)
        {
            var expectedUrl = $"https://api.electricitymap.org/v3/updated-since/" +
                $"?zone={updatedSinceRequest.Zone}" +
                $"&since={updatedSinceRequest.Since:o}" +
                $"&start={updatedSinceRequest.Start:o}" +
                $"&end={updatedSinceRequest.End:o}" +
                $"&limit={updatedSinceRequest.Limit}" +
                $"&threshold={updatedSinceRequest.Threshold}";

            var requestUrl = RequestUrlHelpers
                .ConstructRequest(updatedSinceRequest);

            expectedUrl.Should().Be(requestUrl);
        }

        [Fact]
        public void Constructed_url_with_updated_since_data_without_lat_long_is_correct()
        {
            var updatedSinceRequest = new UpdatedSinceRequest
            {
                Zone = ZoneConstants.Denmark,
                Since = DateTime.Now.AddDays(-5),
                Start = DateTime.Now.AddDays(-2),
                End = DateTime.Now.AddDays(-1),
                Limit = 100,
                Threshold = "P1D"
            };

            var expectedUrl = $"https://api.electricitymap.org/v3/updated-since/" +
                $"?zone=DK&since={updatedSinceRequest.Since:o}" +
                $"&start={updatedSinceRequest.Start:o}" +
                $"&end={updatedSinceRequest.End:o}" +
                $"&limit={updatedSinceRequest.Limit}" +
                $"&threshold={updatedSinceRequest.Threshold}";

            var requestUrl = RequestUrlHelpers
                .ConstructRequest(updatedSinceRequest);

            expectedUrl.Should().Be(requestUrl);
        }

        [Fact]
        public void Constructed_url_with_updated_since_data_with_lat_long_is_correct()
        {
            var updatedSinceRequest = new UpdatedSinceRequest
            {
                Latitude = 55.9553455,
                Longitude = 9.9264833,
                Since = DateTime.Now.AddDays(-5),
                Start = DateTime.Now.AddDays(-2),
                End = DateTime.Now.AddDays(-1),
                Limit = 100,
                Threshold = "P1D"
            };

            var expectedUrl = $"https://api.electricitymap.org/v3/updated-since/" +
                $"?lat={updatedSinceRequest.Latitude}" +
                $"&lon={updatedSinceRequest.Longitude}" +
                $"&since={updatedSinceRequest.Since:o}" +
                $"&start={updatedSinceRequest.Start:o}" +
                $"&end={updatedSinceRequest.End:o}" +
                $"&limit={updatedSinceRequest.Limit}" +
                $"&threshold={updatedSinceRequest.Threshold}";

            var requestUrl = RequestUrlHelpers.ConstructRequest(updatedSinceRequest);

            expectedUrl.Should().Be(requestUrl);
        }

        [Fact]
        public void Constructed_url_with_updated_since_data_returns_exception_without_zone_or_coor()
        {
            var updatedSinceRequest = new UpdatedSinceRequest
            {
                Since = DateTime.Now.AddDays(-5),
                Start = DateTime.Now.AddDays(-2),
                End = DateTime.Now.AddDays(-1),
                Limit = 100,
                Threshold = "P1D"
            };

            Assert.Throws<ArgumentNullException>(() => RequestUrlHelpers.ConstructRequest(updatedSinceRequest));
        }
    }
}