using Newtonsoft.Json;
using System;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    public class MarginalForecast
    {
        [JsonProperty("marginalCarbonIntensity")]
        public int MarginalCarbonIntensity { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }
    }
}