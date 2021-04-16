using ElectricityMap.DotNet.Client.Models.Common;
using ElectricityMap.DotNet.Client.Models.History;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Recent
{
    /// <summary>
    /// The last 24h of carbon intensity (in gCO2eq/kWh) of an area.
    /// </summary>
    public class RecentCarbonIntensityHistory : BaseZone
    {
        [JsonProperty("history")]
        public IEnumerable<CarbonIntensityHistory> CarbonIntensityHistory { get; set; } = default!;
    }
}