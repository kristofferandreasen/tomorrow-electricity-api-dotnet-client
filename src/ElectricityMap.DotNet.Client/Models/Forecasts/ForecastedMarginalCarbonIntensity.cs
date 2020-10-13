using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    public class ForecastedMarginalCarbonIntensity
    {
        [JsonProperty("zone")]
        public string Zone { get; set; }

        [JsonProperty("forecast")]
        public IEnumerable<MarginalForecast> Forecast { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }

    public class MarginalForecast
    {
        [JsonProperty("marginalCarbonIntensity")]
        public int MarginalCarbonIntensity { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }
    }
}