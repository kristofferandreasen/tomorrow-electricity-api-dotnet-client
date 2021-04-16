using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Breakdown
{
    /// <summary>
    /// Past power breakdown of an area.
    /// </summary>
    public class PastPowerBreakdownHistory : BaseBreakdown
    {
        [JsonProperty("powerConsumptionBreakdown")]
        public Dictionary<string, int?> PowerConsumptionBreakdown { get; set; } = default!;

        [JsonProperty("powerProductionBreakdown")]
        public Dictionary<string, int?> PowerProductionBreakdown { get; set; } = default!;

        [JsonProperty("powerImportBreakdown")]
        public Dictionary<string, double?> PowerImportBreakdown { get; set; } = default!;

        [JsonProperty("powerExportBreakdown")]
        public Dictionary<string, double?> PowerExportBreakdown { get; set; } = default!;

        [JsonProperty("fossilFreePercentage")]
        public int FossilFreePercentage { get; set; }

        [JsonProperty("renewablePercentage")]
        public int RenewablePercentage { get; set; }

        [JsonProperty("powerConsumptionTotal")]
        public int PowerConsumptionTotal { get; set; }

        [JsonProperty("powerProductionTotal")]
        public int PowerProductionTotal { get; set; }

        [JsonProperty("powerImportTotal")]
        public int PowerImportTotal { get; set; }

        [JsonProperty("powerExportTotal")]
        public int PowerExportTotal { get; set; }
    }
}