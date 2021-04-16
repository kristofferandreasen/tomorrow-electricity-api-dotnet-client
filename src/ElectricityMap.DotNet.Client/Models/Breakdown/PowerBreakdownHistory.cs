using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Breakdown
{
    public class PowerBreakdownHistory : BaseDatetime
    {
        [JsonProperty("fossilFreePercentage")]
        public int FossilFreePercentage { get; set; }

        [JsonProperty("powerConsumptionBreakdown")]
        public Dictionary<string, int?> PowerConsumptionBreakdown { get; set; } = default!;

        [JsonProperty("powerConsumptionTotal")]
        public int PowerConsumptionTotal { get; set; }

        [JsonProperty("powerImportBreakdown")]
        public Dictionary<string, int?> PowerImportBreakdown { get; set; } = default!;

        [JsonProperty("powerImportTotal")]
        public int PowerImportTotal { get; set; }

        [JsonProperty("powerExportBreakdown")]
        public Dictionary<string, int?> PowerExportBreakdown { get; set; } = default!;

        [JsonProperty("powerExportTotal")]
        public int PowerExportTotal { get; set; }

        [JsonProperty("powerProductionBreakdown")]
        public Dictionary<string, int?> PowerProductionBreakdown { get; set; } = default!;

        [JsonProperty("powerProductionTotal")]
        public int PowerProductionTotal { get; set; }

        [JsonProperty("renewablePercentage")]
        public int RenewablePercentage { get; set; }
    }
}