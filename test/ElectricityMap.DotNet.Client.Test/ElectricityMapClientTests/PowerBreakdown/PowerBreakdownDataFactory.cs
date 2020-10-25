using ElectricityMap.DotNet.Client.Models.History;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.PowerBreakdown
{
    public class PowerBreakdownDataFactory
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

        public LivePowerBreakdown GetLivePowerBreakdownData()
        {
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

            return livePowerbreakdown;
        }

        public RecentPowerBreakdownHistory GetRecentPowerBreakdownData()
        {
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

            return recentPowerbreakdown;
        }

        public PastPowerBreakdownHistory GetPastPowerBreakdownData()
        {
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

            return powerBreakdownHistory;
        }

        public ForecastedPowerConsumptionBreakdown GetForecastPowerBreakdownData()
        {
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

            return powerBreakdownForecast;
        }

        public ForecastedMarginalPowerConsumptionBreakdown GetForecastedMarginalPowerBreakdownData()
        {
            var marginalPowerConsumptionBreakdown = new MarginalPowerConsumptionBreakdown
            {
                Biomass = 100d,
                Coal = 100d,
                Gas = 100d,
                HydroDischarge = 100d,
                Geothermal = 100d,
                Hydro = 100d,
                HydroCharge = 100d,
                Nuclear = 100d,
                Oil = 100d,
                Solar = 100d,
                Wind = 100d,
                Unknown = 100d
            };

            var marginalPowerForecast1 = new MarginalPowerForecast
            {
                Datetime = DateTime.Now,
                MarginalPowerConsumptionBreakdown = marginalPowerConsumptionBreakdown
            };

            var marginalPowerForecast2 = new MarginalPowerForecast
            {
                Datetime = DateTime.Now,
                MarginalPowerConsumptionBreakdown = marginalPowerConsumptionBreakdown
            };

            var forecastMarginalPowerConsumption = new ForecastedMarginalPowerConsumptionBreakdown
            {
                Zone = "DK-DK1",
                UpdatedAt = DateTime.Now,
                Forecast = new List<MarginalPowerForecast>() { marginalPowerForecast1, marginalPowerForecast2 }
            };

            return forecastMarginalPowerConsumption;
        }
    }
}