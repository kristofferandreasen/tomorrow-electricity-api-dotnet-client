using ElectricityMap.DotNet.Client.Constants;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests
{
    public class CarbonIntensityTests
    {
        private readonly ElectricityMapClient _electricityMapClient;

        public CarbonIntensityTests()
        {
            _electricityMapClient = new ElectricityMapClient("YourApiKey");
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
        public async void Carbon_intensity_recent_zone()
        {
            RecentCarbonIntensityHistory data = await _electricityMapClient.GetRecentCarbonIntensityHistoryAsync(ZoneConstants.Denmark_West_Denmark);

            Assert.NotNull(data);
        }

        [Fact]
        public async void Carbon_intensity_recent_lat_long()
        {
            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            RecentCarbonIntensityHistory data = await _electricityMapClient.GetRecentCarbonIntensityHistoryAsync(latitude, longitude);

            Assert.NotNull(data);
        }
    }
}