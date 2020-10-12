using ElectricityMap.DotNet.Client.Models;
using System;
using System.Threading.Tasks;

namespace ElectricityMap.DotNet.Client.Interfaces
{
    public interface IElectricityMapClient
    {
        Task<Zones> GetZonesAsync();
        Task<LiveCarbonIntentsity> GetLiveCarbonIntensityAsync(string zone, double? longitude, double? latitude);
        Task<LivePowerBreakdown> GetLivePowerBreakdownAsync(string zone, double? longitude, double? latitude);
        Task<RecentCarbonIntensityHistory> GetRecentCarbonIntensityHistoryAsync(string zone, double? longitude, double? latitude);
        Task<RecentPowerBreakdownHistory> GetRecentPowerBreakdownHistoryAsync(string zone, double? longitude, double? latitude);
        Task<PastCarbonIntensityHistory> GetPastCarbonIntensityHistoryAsync(string zone, double? longitude, double? latitude, DateTime datetime);
        Task<PastPowerBreakdownHistory> GetPastPowerBreakdownHistoryAsync(string zone, double? longitude, double? latitude, DateTime datetime);
        Task<ForecastedCarbonIntensity> GetForecastedCarbonIntensityAsync(string zone, double? longitude, double? latitude);
        Task<ForecastedPowerConsumptionBreakdown> GetForecastedPowerConsumptionBreakdownAsync(string zone, double? longitude, double? latitude);
        Task<ForecastedMarginalCarbonIntensity> GetForecastedMarginalCarbonIntensityAsync(string zone, double? longitude, double? latitude);
        Task<ForecastedMarginalPowerConsumptionBreakdown> GetForecastedMarginalPowerConsumptionBreakdownAsync(string zone, double? longitude, double? latitude);
        Task<UpdatedSince> GetUpdateInfoAsync(UpdatedSinceRequest updatedSinceRequest);
    }
}