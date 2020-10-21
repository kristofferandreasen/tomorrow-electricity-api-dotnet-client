using ElectricityMap.DotNet.Client.Constants;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests
{
    public class PowerBreakdownTests
    {
        private readonly ElectricityMapClient _electricityMapClient;

        public PowerBreakdownTests()
        {
            _electricityMapClient = new ElectricityMapClient("YourApiKey");
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

        [Fact]
        public async void Power_breakdown_recent_zone()
        {
            RecentPowerBreakdownHistory data = await _electricityMapClient.GetRecentPowerBreakdownHistoryAsync(ZoneConstants.Denmark_West_Denmark);

            Assert.NotNull(data);
        }

        [Fact]
        public async void Power_breakdown_recent_lat_long()
        {
            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            RecentPowerBreakdownHistory data = await _electricityMapClient.GetRecentPowerBreakdownHistoryAsync(latitude, longitude);

            Assert.NotNull(data);
        }
    }
}