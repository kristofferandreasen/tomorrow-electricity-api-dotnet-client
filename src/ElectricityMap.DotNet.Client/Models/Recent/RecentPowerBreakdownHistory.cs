using ElectricityMap.DotNet.Client.Models.Breakdown;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Recent
{
    /// <summary>
    /// The last 24h of power consumption and production breakdown of an area,
    /// which represents the physical origin of electricity broken down by production type.
    /// </summary>
    public class RecentPowerBreakdownHistory
    {
        [JsonProperty("zone")]
        public string Zone { get; set; } = default!;

        [JsonProperty("history")]
        public IEnumerable<PowerBreakdownHistory> History { get; set; } = default!;
    }
}