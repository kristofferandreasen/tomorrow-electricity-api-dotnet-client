using System.Collections.Generic;
using ElectricityMap.DotNet.Client.Models.Breakdown;
using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Live
{
    /// <summary>
    /// The last known data about the origin of electricity in an area.
    /// "powerProduction" (in MW) represents the electricity produced in the zone, broken down by production type.
    /// "powerConsumption" (in MW) represents the electricity consumed in the zone,
    /// after taking into account imports and exports, and broken down by production type.
    /// "powerExport" and "Power import" (in MW) represent the physical electricity flows at the zone border.
    /// "renewablePercentage" and "fossilFreePercentage" refers to the % of the power consumption breakdown
    /// coming from renewables or fossil-free power plants (renewables and nuclear).
    /// </summary>
    public class LivePowerBreakdown : BaseEntity
    {
        [JsonProperty("powerProductionBreakdown")]
        public Dictionary<string, int?> PowerProductionBreakdown { get; set; } = default!;

        [JsonProperty("powerProductionTotal")]
        public int PowerProductionTotal { get; set; }

        [JsonProperty("powerConsumptionBreakdown")]
        public Dictionary<string, int?> PowerConsumptionBreakdown { get; set; } = default!;

        [JsonProperty("powerConsumptionTotal")]
        public int PowerConsumptionTotal { get; set; }

        [JsonProperty("powerImportBreakdown")]
        public PowerZoneBreakdown PowerImportBreakdown { get; set; } = default!;

        [JsonProperty("powerImportTotal")]
        public int PowerImportTotal { get; set; }

        [JsonProperty("powerExportBreakdown")]
        public PowerZoneBreakdown PowerExportBreakdown { get; set; } = default!;

        [JsonProperty("powerExportTotal")]
        public int PowerExportTotal { get; set; }

        [JsonProperty("fossilFreePercentage")]
        public int FossilFreePercentage { get; set; }

        [JsonProperty("renewablePercentage")]
        public int RenewablePercentage { get; set; }
    }
}
