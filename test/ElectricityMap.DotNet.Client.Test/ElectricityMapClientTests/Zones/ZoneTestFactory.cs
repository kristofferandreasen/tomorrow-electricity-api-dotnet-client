using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Zones;
using Moq;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.Zones
{
    public class ZoneTestFactory
    {
        public IElectricityMapClient SetupLiveCarbonIntensityMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            string[] access = { 
                "https://api.electricitymap.org/v3/carbon-intensity/latest",
                "https://api.electricitymap.org/v3/power-consumption-breakdown/latest"
            };

            var zoneData = new ZoneData
            {
                CountryName = "Denmark",
                ZoneName = "DK-DK1",
                Access = access
            };

            var zoneDict = new Dictionary<string, ZoneData>()
            {
                { "DK-DK1", zoneData }
            };

            serviceMoq
                .Setup(o => o.GetAvailableZonesAsync())
                .ReturnsAsync(zoneDict);

            return serviceMoq.Object;
        }
    }
}