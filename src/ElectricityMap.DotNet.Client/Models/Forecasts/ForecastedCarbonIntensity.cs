using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    /// <summary>
    /// The forecasted carbon intensity (in gCO2eq/kWh) of an area.
    /// </summary>
    public class ForecastedCarbonIntensity
    {
        [JsonProperty("zone")]
        public string Zone { get; set; }

        [JsonProperty("forecast")]
        public IEnumerable<Forecast> Forecast { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }

    public class Forecast
    {
        [JsonProperty("carbonIntensity")]
        public int CarbonIntensity { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }
    }
}