using ElectricityMap.DotNet.Client.Constants;
using Xunit;

namespace ElectricityMap.DotNet.Client.Helpers
{
    public class RequestUrlHelpersTest
    {
        [Theory]
        [InlineData(ApiAreas.Zones)]
        [InlineData(ApiAreas.CarbonIntensity)]
        [InlineData(ApiAreas.PowerConsumptionBreakdown)]
        [InlineData(ApiAreas.MarginalCarbonIntensity)]
        [InlineData(ApiAreas.MarginalPowerConsumptionBreakdown)]
        [InlineData(ApiAreas.UpdatedSince)]
        public void Constructed_area_url_is_correct(string area)
        {
            var expectedUrl = $"https://api.electricitymap.org/v3/{area}";
            var requestUrl = RequestUrlHelpers.ConstructRequest(area);

            Assert.Equal(expectedUrl, requestUrl);
        }

        [Theory]
        [InlineData(ApiAreas.CarbonIntensity, ApiActions.Forecast, ZoneConstants.Denmark)]
        [InlineData(ApiAreas.CarbonIntensity, ApiActions.History, ZoneConstants.Namibia)]
        [InlineData(ApiAreas.PowerConsumptionBreakdown, ApiActions.Latest, ZoneConstants.Estonia)]
        [InlineData(ApiAreas.PowerConsumptionBreakdown, ApiActions.Forecast, ZoneConstants.Nepal)]
        [InlineData(ApiAreas.MarginalCarbonIntensity, ApiActions.History, ZoneConstants.Ukraine)]
        [InlineData(ApiAreas.MarginalPowerConsumptionBreakdown, ApiActions.Latest, ZoneConstants.United_States_Alabama)]
        public void Constructed_url_is_correct(string area, string action, string zone)
        {
            var expectedUrl = $"https://api.electricitymap.org/v3/{area}{action}?zone={zone}";
            var requestUrl = RequestUrlHelpers.ConstructRequest(area, action, zone);

            Assert.Equal(expectedUrl, requestUrl);
        }
    }
}