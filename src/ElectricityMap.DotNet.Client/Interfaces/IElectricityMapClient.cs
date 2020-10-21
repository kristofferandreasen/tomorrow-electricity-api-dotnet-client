using ElectricityMap.DotNet.Client.Models;
using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.History;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using ElectricityMap.DotNet.Client.Models.Updates;
using ElectricityMap.DotNet.Client.Models.Zones;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElectricityMap.DotNet.Client.Interfaces
{
    public interface IElectricityMapClient
    {
        Task<Dictionary<string, ZoneData>> GetAvailableZonesAsync();
        Task<LiveCarbonIntensity> GetLiveCarbonIntensityAsync(string zone);
        Task<LiveCarbonIntensity> GetLiveCarbonIntensityAsync(double latitude, double longitude);
        Task<LivePowerBreakdown> GetLivePowerBreakdownAsync(string zone);
        Task<LivePowerBreakdown> GetLivePowerBreakdownAsync(double latitude, double longitude);
        Task<RecentCarbonIntensityHistory> GetRecentCarbonIntensityHistoryAsync(string zone);
        Task<RecentCarbonIntensityHistory> GetRecentCarbonIntensityHistoryAsync(double latitude, double longitude);
        Task<RecentPowerBreakdownHistory> GetRecentPowerBreakdownHistoryAsync(string zone);
        Task<RecentPowerBreakdownHistory> GetRecentPowerBreakdownHistoryAsync(double latitude, double longitude);
        Task<PastCarbonIntensityHistory> GetPastCarbonIntensityHistoryAsync(string zone, DateTime datetime);
        Task<PastCarbonIntensityHistory> GetPastCarbonIntensityHistoryAsync(double latitude, double longitude, DateTime datetime);
        Task<PastPowerBreakdownHistory> GetPastPowerBreakdownHistoryAsync(string zone, DateTime datetime);
        Task<PastPowerBreakdownHistory> GetPastPowerBreakdownHistoryAsync(double latitude, double longitude, DateTime datetime);
        Task<ForecastedCarbonIntensity> GetForecastedCarbonIntensityAsync(string zone);
        Task<ForecastedCarbonIntensity> GetForecastedCarbonIntensityAsync(double latitude, double longitude);
        Task<ForecastedPowerConsumptionBreakdown> GetForecastedPowerConsumptionBreakdownAsync(string zone);
        Task<ForecastedPowerConsumptionBreakdown> GetForecastedPowerConsumptionBreakdownAsync(double latitude, double longitude);
        Task<ForecastedMarginalCarbonIntensity> GetForecastedMarginalCarbonIntensityAsync(string zone);
        Task<ForecastedMarginalCarbonIntensity> GetForecastedMarginalCarbonIntensityAsync(double latitude, double longitude);
        Task<ForecastedMarginalPowerConsumptionBreakdown> GetForecastedMarginalPowerConsumptionBreakdownAsync(string zone);
        Task<ForecastedMarginalPowerConsumptionBreakdown> GetForecastedMarginalPowerConsumptionBreakdownAsync(double latitude, double longitude);
        Task<UpdatedSince> GetUpdateInfoAsync(UpdatedSinceRequest updatedSinceRequest);
    }
}