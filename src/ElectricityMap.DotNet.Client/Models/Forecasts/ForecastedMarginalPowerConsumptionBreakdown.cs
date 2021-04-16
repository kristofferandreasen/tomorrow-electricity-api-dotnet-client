using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    /// <summary>
    ///  The forecasted marginal power consumption breakdown of an area,
    ///  which represents the physical marginal origin of electricity broken down by production type.
    /// </summary>
    public class ForecastedMarginalPowerConsumptionBreakdown : BaseForecast
    {
        [JsonProperty("forecast")]
        public IEnumerable<MarginalPowerForecast> Forecast { get; set; } = default!;
    }
}