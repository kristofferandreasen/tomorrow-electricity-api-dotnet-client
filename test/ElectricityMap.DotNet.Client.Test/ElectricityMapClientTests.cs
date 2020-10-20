using ElectricityMap.DotNet.Client.Models.Zones;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test
{
    public class ElectricityMapClientTests
    {
        private readonly ElectricityMapClient _electricityMapClient;

        public ElectricityMapClientTests()
        {
            _electricityMapClient = new ElectricityMapClient();
        }

        [Fact]
        public async void Zones_are_available_without_api_key()
        {
            Zones zones = await _electricityMapClient.GetZonesAsync();

            Assert.NotNull(zones);
        }
    }
}