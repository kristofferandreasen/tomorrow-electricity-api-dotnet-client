using System.Collections.Generic;
using ElectricityMap.DotNet.Client.Models.Breakdown;
using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Recent
{
    /// <summary>
    /// The last 24h of power consumption and production breakdown of an area,
    /// which represents the physical origin of electricity broken down by production type.
    /// </summary>
    public class RecentPowerBreakdownHistory : BaseZone
    {
        [JsonProperty("history")]
        public IEnumerable<PowerBreakdownHistory> History { get; set; } = default!;
    }
}
