using System.Collections.Generic;
using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    /// <summary>
    /// The forecasted power consumption breakdown of an area,
    /// which represents the physical origin of electricity broken down by production type.
    /// </summary>
    public class ForecastedPowerConsumptionBreakdown : BaseForecast
    {
        [JsonProperty("forecast")]
        public IEnumerable<PowerConsumptionForecast> Forecast { get; set; } = default!;
    }
}
