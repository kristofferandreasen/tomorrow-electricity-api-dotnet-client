using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Zones
{
    public class ForecastedPowerConsumptionBreakdown
    {
        [JsonProperty("zone")]
        public string Zone { get; set; }

        [JsonProperty("forecast")]
        public IEnumerable<Forecast> Forecast { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }

    public class Forecast
    {
        [JsonProperty("powerConsumptionBreakdown")]
        public PowerConsumptionBreakdown PowerConsumptionBreakdown { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }

        [JsonProperty("powerConsumptionTotal")]
        public int PowerConsumptionTotal { get; set; }
    }

    public class PowerConsumptionBreakdown
    {
        [JsonProperty("biomass")]
        public int Biomass { get; set; }

        [JsonProperty("coal")]
        public int Coal { get; set; }

        [JsonProperty("gas")]
        public int Gas { get; set; }

        [JsonProperty("hydro")]
        public int Hydro { get; set; }

        [JsonProperty("nuclear")]
        public int Nuclear { get; set; }

        [JsonProperty("solar")]
        public int Solar { get; set; }

        [JsonProperty("wind")]
        public int Wind { get; set; }

        [JsonProperty("unknown")]
        public int Unknown { get; set; }
    }
}