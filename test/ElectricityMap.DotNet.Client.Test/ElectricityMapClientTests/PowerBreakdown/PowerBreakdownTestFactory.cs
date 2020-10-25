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
        private PowerBreakdownDataFactory dataFactory = new PowerBreakdownDataFactory();

        public IElectricityMapClient SetupLivePowerBreakdownMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetLivePowerBreakdownData();

            serviceMoq
                .Setup(o => o.GetLivePowerBreakdownAsync(It.IsAny<string>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupLivePowerBreakdownMocksWithLatLong()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetLivePowerBreakdownData();

            serviceMoq
                .Setup(o => o.GetLivePowerBreakdownAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupRecentPowerBreakdownMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetRecentPowerBreakdownData();

            serviceMoq
                .Setup(o => o.GetRecentPowerBreakdownHistoryAsync(It.IsAny<string>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupRecentPowerBreakdownMocksWithLatLong()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetRecentPowerBreakdownData();

            serviceMoq
                .Setup(o => o.GetRecentPowerBreakdownHistoryAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupPastPowerBreakdownMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetPastPowerBreakdownData();

            serviceMoq
                .Setup(o => o.GetPastPowerBreakdownHistoryAsync(It.IsAny<string>(), It.IsAny<DateTime>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupPastPowerBreakdownMocksWithLatLong()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetPastPowerBreakdownData();

            serviceMoq
                .Setup(o => o.GetPastPowerBreakdownHistoryAsync(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<DateTime>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupForecastPowerBreakdownMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetForecastPowerBreakdownData();

            serviceMoq
                .Setup(o => o.GetForecastedPowerConsumptionBreakdownAsync(It.IsAny<string>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupForecastPowerBreakdownMocksWithLatLong()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetForecastPowerBreakdownData();

            serviceMoq
                .Setup(o => o.GetForecastedPowerConsumptionBreakdownAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupMarginalForecastPowerBreakdownMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetForecastedMarginalPowerBreakdownData();

            serviceMoq
                .Setup(o => o.GetForecastedMarginalPowerConsumptionBreakdownAsync(It.IsAny<string>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupMarginalForecastPowerBreakdownMocksWithLatLong()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetForecastedMarginalPowerBreakdownData();

            serviceMoq
                .Setup(o => o.GetForecastedMarginalPowerConsumptionBreakdownAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }
    }
}
