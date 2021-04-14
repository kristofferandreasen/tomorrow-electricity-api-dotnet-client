using Newtonsoft.Json;
using System;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    public class Forecast
    {
        [JsonProperty("carbonIntensity")]
        public int CarbonIntensity { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }
    }
}