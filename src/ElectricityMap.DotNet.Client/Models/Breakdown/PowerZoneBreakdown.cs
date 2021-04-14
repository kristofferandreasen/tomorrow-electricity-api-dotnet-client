using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Breakdown
{
    public class PowerZoneBreakdown
    {
        public Dictionary<string, int?> Zones { get; set; } = default!;
    }
}