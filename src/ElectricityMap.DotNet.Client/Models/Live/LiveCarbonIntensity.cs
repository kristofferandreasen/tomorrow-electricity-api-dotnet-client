using Newtonsoft.Json;
using System;

namespace ElectricityMap.DotNet.Client.Models.Live
{
    /// <summary>
    /// The last known carbon intensity (in gCO2eq/kWh) of electricity consumed in an area.
    /// </summary>
    public class LiveCarbonIntensity
    {
        [JsonProperty("zone")]
        public string Zone { get; set; } = default!;

        [JsonProperty("carbonIntensity")]
        public int CarbonIntensity { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}