using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    /// <summary>
    /// The forecasted marginal carbon intensity (in gCO2eq/kWh) of an area.
    /// </summary>
    public class ForecastedMarginalCarbonIntensity
    {
        [JsonProperty("zone")]
        public string Zone { get; set; } = default!;

        [JsonProperty("forecast")]
        public IEnumerable<MarginalForecast> Forecast { get; set; } = default!;

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}