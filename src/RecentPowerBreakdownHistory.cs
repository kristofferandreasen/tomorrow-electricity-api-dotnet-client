using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Zones
{
    public class RecentPowerBreakdownHistory
    {
        [JsonProperty("zone")]
        public string Zone { get; set; }

        [JsonProperty("history")]
        public IEnumerable<History> History { get; set; }
    }

    public class History
    {
        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }

        [JsonProperty("fossilFreePercentage")]
        public int FossilFreePercentage { get; set; }

        [JsonProperty("powerConsumptionBreakdown")]
        public Dictionary<string, int?> PowerConsumptionBreakdown { get; set; }

        [JsonProperty("powerConsumptionTotal")]
        public int PowerConsumptionTotal { get; set; }

        [JsonProperty("powerImportBreakdown")]
        public PowerPortBreakdown PowerImportBreakdown { get; set; }

        [JsonProperty("powerImportTotal")]
        public int PowerImportTotal { get; set; }

        [JsonProperty("powerExportBreakdown")]
        public Dictionary<string, int?> PowerExportBreakdown { get; set; }

        [JsonProperty("powerExportTotal")]
        public int PowerExportTotal { get; set; }

        [JsonProperty("powerProductionBreakdown")]
        public Dictionary<string, int?> PowerProductionBreakdown { get; set; }

        [JsonProperty("powerProductionTotal")]
        public int PowerProductionTotal { get; set; }

        [JsonProperty("renewablePercentage")]
        public int RenewablePercentage { get; set; }
    }
}