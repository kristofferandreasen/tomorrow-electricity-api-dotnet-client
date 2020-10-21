using ElectricityMap.DotNet.Client.Models.Zones;
using System.Collections.Generic;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests
{
    public class ZonesTests
    {
        private readonly ElectricityMapClient _electricityMapClient;

        public ZonesTests()
        {
            _electricityMapClient = new ElectricityMapClient("YourApiKey");
        }

        [Fact]
        public async void Zones_are_available()
        {
            Dictionary<string, ZoneData> zones = await _electricityMapClient.GetAvailableZonesAsync();

            Assert.NotNull(zones);
        }
    }
}