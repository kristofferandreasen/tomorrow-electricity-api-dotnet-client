﻿using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Breakdown
{
    public class PowerConsumptionBreakdown
    {
        [JsonProperty("biomass")]
        public int? Biomass { get; set; }

        [JsonProperty("coal")]
        public int? Coal { get; set; }

        [JsonProperty("gas")]
        public int? Gas { get; set; }

        [JsonProperty("hydro")]
        public int? Hydro { get; set; }

        [JsonProperty("nuclear")]
        public int? Nuclear { get; set; }

        [JsonProperty("solar")]
        public int? Solar { get; set; }

        [JsonProperty("wind")]
        public int? Wind { get; set; }

        [JsonProperty("unknown")]
        public int? Unknown { get; set; }
    }
}