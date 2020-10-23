using Newtonsoft.Json;
using System;

namespace ElectricityMap.DotNet.Client.Models.History
{
    public class PastCarbonIntensityHistory
    {
        [JsonProperty("zone")]
        public string Zone { get; set; }

        [JsonProperty("carbonIntensity")]
        public int CarbonIntensity { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}