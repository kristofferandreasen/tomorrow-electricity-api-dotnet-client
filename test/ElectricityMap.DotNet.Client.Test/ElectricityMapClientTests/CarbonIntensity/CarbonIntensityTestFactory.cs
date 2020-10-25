using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.History;
using ElectricityMap.DotNet.Client.Models.Recent;
using ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.CarbonIntensity;
using Moq;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Test.CarbonIntensity
{
    public class CarbonIntensityTestFactory
    {
        private CarbonIntensityDataFactory dataFactory = new CarbonIntensityDataFactory();

        public IElectricityMapClient SetupLiveCarbonIntensityMocksWithZone() 
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetLiveCarbonIntensityData();

            serviceMoq
                .Setup(o => o.GetLiveCarbonIntensityAsync(It.IsAny<string>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupLiveCarbonIntensityMocksWithLatitudeLongitude() 
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetLiveCarbonIntensityData();

            serviceMoq
                .Setup(o => o.GetLiveCarbonIntensityAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupRecentCarbonIntensityMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetRecentCarbonIntensityData();

            serviceMoq
                .Setup(o => o.GetRecentCarbonIntensityHistoryAsync(It.IsAny<string>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupRecentCarbonIntensityMocksWithLatitudeLongitude()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetRecentCarbonIntensityData();

            serviceMoq
                .Setup(o => o.GetRecentCarbonIntensityHistoryAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupPastCarbonIntensityMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetPastCarbonIntensityData();

            serviceMoq
                .Setup(o => o.GetPastCarbonIntensityHistoryAsync(It.IsAny<string>(), It.IsAny<DateTime>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupPastCarbonIntensityMocksWithLatitudeLongitude()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetPastCarbonIntensityData();

            serviceMoq
                .Setup(o => o.GetPastCarbonIntensityHistoryAsync(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<DateTime>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupForecastedCarbonIntensityMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            var forecast = new List<Forecast>();
            var forecast1 = new Forecast
            {
                CarbonIntensity = 100,
                Datetime = DateTime.Now
            };

            var forecast2 = new Forecast
            {
                CarbonIntensity = 200,
                Datetime = DateTime.Now.AddHours(-2)
            };

            forecast.Add(forecast1);
            forecast.Add(forecast2);

            serviceMoq
                .Setup(o => o.GetForecastedCarbonIntensityAsync(It.IsAny<string>()))
                .ReturnsAsync(
                    new ForecastedCarbonIntensity
                    {
                        Zone = "DK-DK1",
                        Forecast = forecast,
                        UpdatedAt = DateTime.Now
                    });

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupForecastedCarbonIntensityMocksWithLatitudeLongitude()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            var forecast = new List<Forecast>();
            var forecast1 = new Forecast
            {
                CarbonIntensity = 100,
                Datetime = DateTime.Now
            };

            var forecast2 = new Forecast
            {
                CarbonIntensity = 200,
                Datetime = DateTime.Now.AddHours(-2)
            };

            forecast.Add(forecast1);
            forecast.Add(forecast2);

            serviceMoq
                .Setup(o => o.GetForecastedCarbonIntensityAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync(
                    new ForecastedCarbonIntensity
                    {
                        Zone = "DK-DK1",
                        Forecast = forecast,
                        UpdatedAt = DateTime.Now
                    });

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupForecastedMarginalCarbonIntensityMocksWithZone()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            var forecast = new List<MarginalForecast>();
            var forecast1 = new MarginalForecast
            {
                MarginalCarbonIntensity = 100,
                Datetime = DateTime.Now
            };

            var forecast2 = new MarginalForecast
            {
                MarginalCarbonIntensity = 200,
                Datetime = DateTime.Now.AddHours(-2)
            };

            forecast.Add(forecast1);
            forecast.Add(forecast2);

            serviceMoq
                .Setup(o => o.GetForecastedMarginalCarbonIntensityAsync(It.IsAny<string>()))
                .ReturnsAsync(
                    new ForecastedMarginalCarbonIntensity
                    {
                        Zone = "DK-DK1",
                        Forecast = forecast,
                        UpdatedAt = DateTime.Now
                    });

            return serviceMoq.Object;
        }

        public IElectricityMapClient SetupForecastedMarginalCarbonIntensityMocksWithLatitudeLongitude()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();

            var forecast = new List<MarginalForecast>();
            var forecast1 = new MarginalForecast
            {
                MarginalCarbonIntensity = 100,
                Datetime = DateTime.Now
            };

            var forecast2 = new MarginalForecast
            {
                MarginalCarbonIntensity = 200,
                Datetime = DateTime.Now.AddHours(-2)
            };

            forecast.Add(forecast1);
            forecast.Add(forecast2);

            serviceMoq
                .Setup(o => o.GetForecastedMarginalCarbonIntensityAsync(It.IsAny<double>(), It.IsAny<double>()))
                .ReturnsAsync(
                    new ForecastedMarginalCarbonIntensity
                    {
                        Zone = "DK-DK1",
                        Forecast = forecast,
                        UpdatedAt = DateTime.Now
                    });

            return serviceMoq.Object;
        }
    }
}