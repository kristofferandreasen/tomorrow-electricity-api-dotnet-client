using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElectricityMap.DotNet.Client.Models;
using ElectricityMap.DotNet.Client.Models.Breakdown;
using ElectricityMap.DotNet.Client.Models.Forecasts;
using ElectricityMap.DotNet.Client.Models.History;
using ElectricityMap.DotNet.Client.Models.Live;
using ElectricityMap.DotNet.Client.Models.Recent;
using ElectricityMap.DotNet.Client.Models.Updates;
using ElectricityMap.DotNet.Client.Models.Zones;

namespace ElectricityMap.DotNet.Client.Interfaces
{
    public interface IElectricityMapClient
    {
        /// <summary>
        /// Returns a list of zones and routes available with your API-key.
        /// </summary>
        /// <returns></returns>
        Task<Dictionary<string, ZoneData>> GetAvailableZonesAsync();

        /// <summary>
        /// Retrieves the last known carbon intensity (in gCO2eq/kWh) of electricity consumed in an area.
        /// </summary>
        /// <param name="zone"></param>
        /// <returns></returns>
        Task<LiveCarbonIntensity> GetLiveCarbonIntensityAsync(string zone);

        /// <summary>
        /// Retrieves the last known carbon intensity (in gCO2eq/kWh) of electricity consumed in an area.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        Task<LiveCarbonIntensity> GetLiveCarbonIntensityAsync(double latitude, double longitude);

        /// <summary>
        /// Retrieves the last known data about the origin of electricity in an area.
        /// "powerProduction" (in MW) represents the electricity produced in the zone,
        /// broken down by production type. "powerConsumption" (in MW) represents the electricity consumed in the zone,
        /// after taking into account imports and exports, and broken down by production type.
        /// "powerExport" and "Power import" (in MW) represent the physical electricity flows at the zone border.
        /// "renewablePercentage" and "fossilFreePercentage" refers to the % of the power consumption breakdown
        /// coming from renewables or fossil-free power plants (renewables and nuclear).
        /// </summary>
        /// <param name="zone"></param>
        /// <returns></returns>
        Task<LivePowerBreakdown> GetLivePowerBreakdownAsync(string zone);

        /// <summary>
        /// Retrieves the last known data about the origin of electricity in an area.
        /// "powerProduction" (in MW) represents the electricity produced in the zone, broken down by production type.
        /// "powerConsumption" (in MW) represents the electricity consumed in the zone, after taking into account imports and exports, and broken down by production type.
        /// "powerExport" and "Power import" (in MW) represent the physical electricity flows at the zone border.
        /// "renewablePercentage" and "fossilFreePercentage" refers to the % of the power consumption breakdown coming from renewables or fossil-free power plants (renewables and nuclear).
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        Task<LivePowerBreakdown> GetLivePowerBreakdownAsync(double latitude, double longitude);

        /// <summary>
        /// Retrieves the last 24h of carbon intensity (in gCO2eq/kWh) of an area.
        /// </summary>
        /// <param name="zone"></param>
        /// <returns></returns>
        Task<RecentCarbonIntensityHistory> GetRecentCarbonIntensityHistoryAsync(string zone);

        /// <summary>
        /// Retrieves the last 24h of carbon intensity (in gCO2eq/kWh) of an area.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        Task<RecentCarbonIntensityHistory> GetRecentCarbonIntensityHistoryAsync(double latitude, double longitude);

        /// <summary>
        /// Retrieves the last 24h of power consumption and production breakdown of an area,
        /// which represents the physical origin of electricity broken down by production type.
        /// </summary>
        /// <param name="zone"></param>
        /// <returns></returns>
        Task<RecentPowerBreakdownHistory> GetRecentPowerBreakdownHistoryAsync(string zone);

        /// <summary>
        /// Retrieves the last 24h of power consumption and production breakdown of an area,
        /// which represents the physical origin of electricity broken down by production type.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        Task<RecentPowerBreakdownHistory> GetRecentPowerBreakdownHistoryAsync(double latitude, double longitude);

        /// <summary>
        /// Retrieves a past carbon intensity (in gCO2eq/kWh) of an area.
        /// </summary>
        /// <param name="zone"></param>
        /// <param name="datetime"></param>
        /// <returns></returns>
        Task<PastCarbonIntensityHistory> GetPastCarbonIntensityHistoryAsync(string zone, DateTime datetime);

        /// <summary>
        /// Retrieves a past carbon intensity (in gCO2eq/kWh) of an area.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="datetime"></param>
        /// <returns></returns>
        Task<PastCarbonIntensityHistory> GetPastCarbonIntensityHistoryAsync(double latitude, double longitude, DateTime datetime);

        /// <summary>
        /// Retrieves a past power breakdown of an area.
        /// </summary>
        /// <param name="zone"></param>
        /// <param name="datetime"></param>
        /// <returns></returns>
        Task<PastPowerBreakdownHistory> GetPastPowerBreakdownHistoryAsync(string zone, DateTime datetime);

        /// <summary>
        /// Retrieves a past power breakdown of an area.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="datetime"></param>
        /// <returns></returns>
        Task<PastPowerBreakdownHistory> GetPastPowerBreakdownHistoryAsync(double latitude, double longitude, DateTime datetime);

        /// <summary>
        /// Retrieves the forecasted carbon intensity (in gCO2eq/kWh) of an area.
        /// </summary>
        /// <param name="zone"></param>
        /// <returns></returns>
        Task<ForecastedCarbonIntensity> GetForecastedCarbonIntensityAsync(string zone);

        /// <summary>
        /// Retrieves the forecasted carbon intensity (in gCO2eq/kWh) of an area.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        Task<ForecastedCarbonIntensity> GetForecastedCarbonIntensityAsync(double latitude, double longitude);

        /// <summary>
        /// Retrieves the forecasted power consumption breakdown of an area,
        /// which represents the physical origin of electricity broken down by production type.
        /// </summary>
        /// <param name="zone"></param>
        /// <returns></returns>
        Task<ForecastedPowerConsumptionBreakdown> GetForecastedPowerConsumptionBreakdownAsync(string zone);

        /// <summary>
        /// Retrieves the forecasted power consumption breakdown of an area,
        /// which represents the physical origin of electricity broken down by production type.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        Task<ForecastedPowerConsumptionBreakdown> GetForecastedPowerConsumptionBreakdownAsync(double latitude, double longitude);

        /// <summary>
        /// Retrieves the forecasted marginal carbon intensity (in gCO2eq/kWh) of an area.
        /// </summary>
        /// <param name="zone"></param>
        /// <returns></returns>
        Task<ForecastedMarginalCarbonIntensity> GetForecastedMarginalCarbonIntensityAsync(string zone);

        /// <summary>
        /// Retrieves the forecasted marginal carbon intensity (in gCO2eq/kWh) of an area.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        Task<ForecastedMarginalCarbonIntensity> GetForecastedMarginalCarbonIntensityAsync(double latitude, double longitude);

        /// <summary>
        /// This endpoint retrieves the forecasted marginal power consumption breakdown of an area,
        /// which represents the physical marginal origin of electricity broken down by production type.
        /// </summary>
        /// <param name="zone"></param>
        /// <returns></returns>
        Task<ForecastedMarginalPowerConsumptionBreakdown> GetForecastedMarginalPowerConsumptionBreakdownAsync(string zone);

        /// <summary>
        /// This endpoint retrieves the forecasted marginal power consumption breakdown of an area,
        /// which represents the physical marginal origin of electricity broken down by production type.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        Task<ForecastedMarginalPowerConsumptionBreakdown> GetForecastedMarginalPowerConsumptionBreakdownAsync(double latitude, double longitude);

        /// <summary>
        /// This endpoint returns a list of timestamps where data has been updated since a specified date for a specified zone.
        /// The 'start' and 'end' parameters can be used to specify a limited timeframe in which to search.
        /// Furthermore, the 'threshold' parameter can be used to filter the timestamps to only include entries with a difference between the time of creation and "updated_at" higher than the threshold.
        /// The output is limited to 100 datapoints by default, but can be set up to 1000.
        /// It can either be queried by zone identifier or by geolocation. The 'start', 'end', 'limit' and 'threshold' parameters are optional.
        /// Access to this endpoint is only authorized if the token has access to one or more 'past' endpoints.
        /// </summary>
        /// <param name="updatedSinceRequest"></param>
        /// <returns></returns>
        Task<UpdatedSince> GetUpdateInfoAsync(UpdatedSinceRequest updatedSinceRequest);
    }
}
