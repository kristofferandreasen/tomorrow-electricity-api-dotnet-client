using ElectricityMap.DotNet.Client.Constants;
using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using Moq;
using System;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test
{
    public class TestFactory
    {
        public Mock<IElectricityMapClient> SetupLiveCarbonIntensityMocksWithZone() 
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            serviceMoq
                .Setup(o => o.GetLiveCarbonIntensityAsync(It.IsAny<string>()))
                .ReturnsAsync(
                    new LiveCarbonIntensity {
                    Zone = "DK-DK1",
                    CarbonIntensity = 100,
                    Datetime = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

            return serviceMoq.Object;
        }

        public Mock<IElectricityMapClient> SetupLiveCarbonIntensityMocksWithLatitudeLongitude() 
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            serviceMoq
                .Setup(o => o.GetLiveCarbonIntensityAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync(
                    new LiveCarbonIntensity {
                    Zone = "DK-DK1",
                    CarbonIntensity = 100,
                    Datetime = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

            return serviceMoq.Object;
        }
    }
}