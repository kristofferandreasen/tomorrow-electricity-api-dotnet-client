using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Live;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.PowerBreakdown
{
    public class PowerBreakdownTests
    {
        private IElectricityMapClient electricityClientZone;

        public PowerBreakdownTests()
        {
            var testFactory = new PowerBreakdownTestFactory();
            electricityClientZone = testFactory.SetupLivePowerBreakdownMocksWithZone();
        }

        [Fact]
        public async void Get_carbon_intensity_live_zone()
        {
            string zone = "DK-DK1";

            LivePowerBreakdown response = await electricityClientZone.GetLivePowerBreakdownAsync(zone);

            Assert.NotNull(response);
        }
    }
}