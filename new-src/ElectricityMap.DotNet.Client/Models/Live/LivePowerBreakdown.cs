using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Live
{
    public class LivePowerBreakdown
    {
        [JsonProperty("zone")]
        public string Zone { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }

        [JsonProperty("powerProductionBreakdown")]
        public Dictionary<string, int?> PowerProductionBreakdown { get; set; }

        [JsonProperty("powerProductionTotal")]
        public int PowerProductionTotal { get; set; }

        [JsonProperty("powerConsumptionBreakdown")]
        public Dictionary<string, int?> PowerConsumptionBreakdown { get; set; }

        [JsonProperty("powerConsumptionTotal")]
        public int PowerConsumptionTotal { get; set; }

        [JsonProperty("powerImportBreakdown")]
        public PowerZoneBreakdown PowerImportBreakdown { get; set; }

        [JsonProperty("powerImportTotal")]
        public int PowerImportTotal { get; set; }

        [JsonProperty("powerExportBreakdown")]
        public PowerZoneBreakdown PowerExportBreakdown { get; set; }

        [JsonProperty("powerExportTotal")]
        public int PowerExportTotal { get; set; }

        [JsonProperty("fossilFreePercentage")]
        public int FossilFreePercentage { get; set; }

        [JsonProperty("renewablePercentage")]
        public int RenewablePercentage { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }

    public class PowerZoneBreakdown
    {
        public Dictionary<string, int?> Zones { get; set; }
    }
}