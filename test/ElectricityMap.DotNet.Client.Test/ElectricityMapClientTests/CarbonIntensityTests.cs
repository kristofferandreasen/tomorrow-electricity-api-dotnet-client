using ElectricityMap.DotNet.Client.Constants;
using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using Moq;
using System;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests
{
    public class CarbonIntensityTests
    {
        private IElectricityMapClient electricityClientZone;
        private IElectricityMapClient electricityClientLatLong;

        public CarbonIntensityTests() 
        {
            var testFactory = new TestFactory();
            electricityClientZone = testFactory.SetupLiveCarbonIntensityMocksWithZone();
            electricityClientLatLong = testFactory.SetupLiveCarbonIntensityMocksWithLatitudeLongitude();
        }

        [Fact]
        public async void Get_carbon_intensity_live_zone()
        {
            string zone = "DK-DK1";

            LiveCarbonIntensity response = await electricityClientZone.GetLiveCarbonIntensityAsync(zone);

            Assert.NotNull(response);
        }

        [Fact]
        public async void Get_carbon_intensity_live_lat_long()
        {
            double latitude = 55.6590875d;
            double longitude = 12.5492117d;
            LiveCarbonIntensity response = await electricityClientLatLong.GetLiveCarbonIntensityAsync(latitude, longitude);

            Assert.NotNull(response);
        }
    }
}