using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Live;
using Moq;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Test.PowerBreakdown
{
    public class PowerBreakdownTestFactory
    {
        public IElectricityMapClient SetupLivePowerBreakdownMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            var powerConsumptionBreakdown = new Dictionary<string, int?>()
            {
                { "oil", 100 },
                { "gas", 100 },
                { "wind", 100 }
            };

            var powerZoneBreakdown = new PowerZoneBreakdown
            {
                Zones = new Dictionary<string, int?>()
                {
                    { "oil", 100 },
                    { "gas", 100 },
                    { "wind", 100 }
                }
            };

            var livePowerbreakdown = new LivePowerBreakdown
            {
                Zone = "DK-DK1",
                Datetime = DateTime.Now,
                PowerConsumptionBreakdown = powerConsumptionBreakdown,
                PowerConsumptionTotal = 100,
                PowerExportBreakdown = powerZoneBreakdown,
                FossilFreePercentage = 50,
                PowerExportTotal = 100,
                PowerImportBreakdown = powerZoneBreakdown,
                PowerImportTotal = 100,
                PowerProductionBreakdown = powerConsumptionBreakdown,
                PowerProductionTotal = 100,
                RenewablePercentage = 90,
                UpdatedAt = DateTime.Now
            };

            serviceMoq
                .Setup(o => o.GetLivePowerBreakdownAsync(It.IsAny<string>()))
                .ReturnsAsync(livePowerbreakdown);

            return serviceMoq.Object;
        }
    }
}
