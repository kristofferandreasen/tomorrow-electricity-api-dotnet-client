using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Zones;
using System.Collections.Generic;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.Zones
{
    public class ZoneTests
    {
        [Fact]
        public async void Zones_are_available()
        {
            var testFactory = new ZoneTestFactory();
            IElectricityMapClient electricityClient = testFactory.SetupLiveCarbonIntensityMocksWithZone();
            Dictionary<string, ZoneData> zones = await electricityClient.GetAvailableZonesAsync();

            Assert.NotNull(zones);
        }
    }
}