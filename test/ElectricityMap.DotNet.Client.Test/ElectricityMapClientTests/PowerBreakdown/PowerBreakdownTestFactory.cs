using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.History;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using Moq;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Test.PowerBreakdown
{
    public class PowerBreakdownTestFactory
    {
        private readonly Dictionary<string, int?> powerConsumptionBreakdown = new Dictionary<string, int?>()
            {
                { "oil", 100 },
                { "gas", 100 },
                { "wind", 100 }
            };

        private readonly PowerZoneBreakdown powerZoneBreakdown = new PowerZoneBreakdown
        {
            Zones = new Dictionary<string, int?>()
                {
                    { "oil", 100 },
                    { "gas", 100 },
                    { "wind", 100 }
                }
        };

        private readonly Dictionary<string, double?> powerImportBreakdown = new Dictionary<string, double?>()
        {
            { "oil", 100d },
            { "gas", 100d },
            { "wind", 100d }
        };

        public IElectricityMapClient SetupLivePowerBreakdownMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

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

        public IElectricityMapClient SetupLivePowerBreakdownMocksWithLatLong()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

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
                .Setup(o => o.GetLivePowerBreakdownAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync(livePowerbreakdown);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupRecentPowerBreakdownMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            var powerBreakdownHistory = new PowerBreakdownHistory
            {
                Datetime = DateTime.Now,
                PowerConsumptionBreakdown = powerConsumptionBreakdown,
                PowerConsumptionTotal = 100,
                PowerExportBreakdown = powerConsumptionBreakdown,
                FossilFreePercentage = 50,
                PowerExportTotal = 100,
                PowerImportBreakdown = powerConsumptionBreakdown,
                PowerImportTotal = 100,
                PowerProductionBreakdown = powerConsumptionBreakdown,
                PowerProductionTotal = 100,
                RenewablePercentage = 90
            };

            var powerBreakdownHistoryList = new List<PowerBreakdownHistory>
            {
                powerBreakdownHistory,
                powerBreakdownHistory
            };

            var recentPowerbreakdown = new RecentPowerBreakdownHistory
            {
                Zone = "DK-DK1",
                History = powerBreakdownHistoryList
            };

            serviceMoq
                .Setup(o => o.GetRecentPowerBreakdownHistoryAsync(It.IsAny<string>()))
                .ReturnsAsync(recentPowerbreakdown);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupRecentPowerBreakdownMocksWithLatLong()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            var powerBreakdownHistory = new PowerBreakdownHistory
            {
                Datetime = DateTime.Now,
                PowerConsumptionBreakdown = powerConsumptionBreakdown,
                PowerConsumptionTotal = 100,
                PowerExportBreakdown = powerConsumptionBreakdown,
                FossilFreePercentage = 50,
                PowerExportTotal = 100,
                PowerImportBreakdown = powerConsumptionBreakdown,
                PowerImportTotal = 100,
                PowerProductionBreakdown = powerConsumptionBreakdown,
                PowerProductionTotal = 100,
                RenewablePercentage = 90
            };

            var powerBreakdownHistoryList = new List<PowerBreakdownHistory>
            {
                powerBreakdownHistory,
                powerBreakdownHistory
            };

            var recentPowerbreakdown = new RecentPowerBreakdownHistory
            {
                Zone = "DK-DK1",
                History = powerBreakdownHistoryList
            };

            serviceMoq
                .Setup(o => o.GetRecentPowerBreakdownHistoryAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync(recentPowerbreakdown);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupPastPowerBreakdownMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            var powerBreakdownHistory = new PastPowerBreakdownHistory
            {
                Datetime = DateTime.Now,
                PowerConsumptionBreakdown = powerConsumptionBreakdown,
                PowerConsumptionTotal = 100,
                PowerExportBreakdown = powerImportBreakdown,
                FossilFreePercentage = 50,
                PowerExportTotal = 100,
                PowerImportBreakdown = powerImportBreakdown,
                PowerImportTotal = 100,
                PowerProductionBreakdown = powerConsumptionBreakdown,
                PowerProductionTotal = 100,
                RenewablePercentage = 90
            };

            serviceMoq
                .Setup(o => o.GetPastPowerBreakdownHistoryAsync(It.IsAny<string>(), It.IsAny<DateTime>()))
                .ReturnsAsync(powerBreakdownHistory);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupPastPowerBreakdownMocksWithLatLong()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            var powerBreakdownHistory = new PastPowerBreakdownHistory
            {
                Datetime = DateTime.Now,
                PowerConsumptionBreakdown = powerConsumptionBreakdown,
                PowerConsumptionTotal = 100,
                PowerExportBreakdown = powerImportBreakdown,
                FossilFreePercentage = 50,
                PowerExportTotal = 100,
                PowerImportBreakdown = powerImportBreakdown,
                PowerImportTotal = 100,
                PowerProductionBreakdown = powerConsumptionBreakdown,
                PowerProductionTotal = 100,
                RenewablePercentage = 90
            };

            serviceMoq
                .Setup(o => o.GetPastPowerBreakdownHistoryAsync(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<DateTime>()))
                .ReturnsAsync(powerBreakdownHistory);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupForecastPowerBreakdownMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            var forecastPowerConsumptionBreakdown = new PowerConsumptionBreakdown
            {
                Biomass = 100,
                Coal = 100,
                Gas = 100,
                Hydro = 100,
                Nuclear = 100,
                Solar = 100,
                Wind = 100,
                Unknown = 10
            };

            var powerConsumptionForecast1 = new PowerConsumptionForecast
            {
                Datetime = DateTime.Now,
                PowerConsumptionTotal = 100,
                PowerConsumptionBreakdown = forecastPowerConsumptionBreakdown
            };

            var powerConsumptionForecast2 = new PowerConsumptionForecast
            {
                Datetime = DateTime.Now,
                PowerConsumptionTotal = 100,
                PowerConsumptionBreakdown = forecastPowerConsumptionBreakdown
            };

            var powerBreakdownForecast = new ForecastedPowerConsumptionBreakdown
            {
                Zone = "DK-DK1",
                UpdatedAt = DateTime.Now,
                Forecast = new List<PowerConsumptionForecast>() { powerConsumptionForecast1, powerConsumptionForecast2 }
            };

            serviceMoq
                .Setup(o => o.GetForecastedPowerConsumptionBreakdownAsync(It.IsAny<string>()))
                .ReturnsAsync(powerBreakdownForecast);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupForecastPowerBreakdownMocksWithLatLong()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            var forecastPowerConsumptionBreakdown = new PowerConsumptionBreakdown
            {
                Biomass = 100,
                Coal = 100,
                Gas = 100,
                Hydro = 100,
                Nuclear = 100,
                Solar = 100,
                Wind = 100,
                Unknown = 10
            };

            var powerConsumptionForecast1 = new PowerConsumptionForecast
            {
                Datetime = DateTime.Now,
                PowerConsumptionTotal = 100,
                PowerConsumptionBreakdown = forecastPowerConsumptionBreakdown
            };

            var powerConsumptionForecast2 = new PowerConsumptionForecast
            {
                Datetime = DateTime.Now,
                PowerConsumptionTotal = 100,
                PowerConsumptionBreakdown = forecastPowerConsumptionBreakdown
            };

            var powerBreakdownForecast = new ForecastedPowerConsumptionBreakdown
            {
                Zone = "DK-DK1",
                UpdatedAt = DateTime.Now,
                Forecast = new List<PowerConsumptionForecast>() { powerConsumptionForecast1, powerConsumptionForecast2 }
            };

            serviceMoq
                .Setup(o => o.GetForecastedPowerConsumptionBreakdownAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync(powerBreakdownForecast);

            return serviceMoq.Object;
        }
    }
}
