using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.History;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.CarbonIntensity
{
    public class CarbonIntensityDataFactory
    {
        public LiveCarbonIntensity GetLiveCarbonIntensityData()
        {
            var liveCarbonIntensity = new LiveCarbonIntensity
            {
                Zone = "DK-DK1",
                CarbonIntensity = 100,
                Datetime = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            return liveCarbonIntensity;
        }

        public RecentCarbonIntensityHistory GetRecentCarbonIntensityData()
        {
            var history1 = new History
            {
                CarbonIntensity = 100,
                Datetime = DateTime.Now
            };

            var history2 = new History
            {
                CarbonIntensity = 200,
                Datetime = DateTime.Now.AddHours(-2)
            };

            var history = new List<History>() { history1, history2 };

            var recentCarbonIntensityHistory = new RecentCarbonIntensityHistory
            {
                Zone = "DK-DK1",
                History = history
            };

            return recentCarbonIntensityHistory;
        }

        public PastCarbonIntensityHistory GetPastCarbonIntensityData()
        {
            var carbonIntensity = new PastCarbonIntensityHistory
            {
                Zone = "DK-DK1",
                CarbonIntensity = 100,
                Datetime = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            return carbonIntensity;
        }

        public ForecastedCarbonIntensity GetForecastedCarbonIntensityData()
        {
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

            var forecast = new List<Forecast>() { forecast1, forecast2 };

            var carbonIntensity = new ForecastedCarbonIntensity
            {
                Zone = "DK-DK1",
                Forecast = forecast,
                UpdatedAt = DateTime.Now
            };

            return carbonIntensity;
        }

        public ForecastedMarginalCarbonIntensity GetForecastedMarginalCarbonIntensityData()
        {
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

            var forecast = new List<MarginalForecast>() { forecast1, forecast2 };

            var carbonIntensity = new ForecastedMarginalCarbonIntensity
            {
                Zone = "DK-DK1",
                Forecast = forecast,
                UpdatedAt = DateTime.Now
            };

            return carbonIntensity;
        }
    }
}