using ElectricityMap.DotNet.Client.Models.Breakdown;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    /// <summary>
    /// The forecasted power consumption breakdown of an area,
    /// which represents the physical origin of electricity broken down by production type.
    /// </summary>
    public class ForecastedPowerConsumptionBreakdown
    {
        [JsonProperty("zone")]
        public string Zone { get; set; } = default!;

        [JsonProperty("forecast")]
        public IEnumerable<PowerConsumptionForecast> Forecast { get; set; } = default!;

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}