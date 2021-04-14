using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    /// <summary>
    ///  The forecasted marginal power consumption breakdown of an area,
    ///  which represents the physical marginal origin of electricity broken down by production type.
    /// </summary>
    public class ForecastedMarginalPowerConsumptionBreakdown
    {
        [JsonProperty("zone")]
        public string Zone { get; set; } = default!;

        [JsonProperty("forecast")]
        public IEnumerable<MarginalPowerForecast> Forecast { get; set; } = default!;

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}