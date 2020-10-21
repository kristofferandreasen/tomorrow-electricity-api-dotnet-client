using ElectricityMap.DotNet.Client.Constants;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Zones;
using System.Collections.Generic;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test
{
    public class ElectricityMapClientTests
    {
        private readonly ElectricityMapClient _electricityMapClient;

        public ElectricityMapClientTests()
        {
            _electricityMapClient = new ElectricityMapClient("YourApiKey");
        }

        [Fact]
        public async void Zones_are_available()
        {
            Dictionary<string, ZoneData> zones = await _electricityMapClient.GetAvailableZonesAsync();

            Assert.NotNull(zones);
        }

        [Fact]
        public async void Carbon_intensity_live_zone()
        {
            LiveCarbonIntensity data = await _electricityMapClient.GetLiveCarbonIntensityAsync(ZoneConstants.Denmark_West_Denmark);

            Assert.NotNull(data);
        }

        [Fact]
        public async void Carbon_intensity_live_lat_long()
        {
            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            LiveCarbonIntensity data = await _electricityMapClient.GetLiveCarbonIntensityAsync(latitude, longitude);

            Assert.NotNull(data);
        }

        [Fact]
        public async void Power_breakdown_live_zone()
        {
            LivePowerBreakdown data = await _electricityMapClient.GetLivePowerBreakdownAsync(ZoneConstants.Denmark_West_Denmark);

            Assert.NotNull(data);
        }

        [Fact]
        public async void Power_breakdown_live_lat_long()
        {
            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            LivePowerBreakdown data = await _electricityMapClient.GetLivePowerBreakdownAsync(latitude, longitude);

            Assert.NotNull(data);
        }
    }
}