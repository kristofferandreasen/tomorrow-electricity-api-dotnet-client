using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Zones
{
    public class ForecastedMarginalPowerConsumption
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
        [JsonProperty("marginalPowerConsumptionBreakdown")]
        public MarginalPowerConsumptionBreakdown MarginalPowerConsumptionBreakdown { get; set; }

        [JsonProperty("datetime")]
        public DateTimeOffset Datetime { get; set; }
    }

    public class MarginalPowerConsumptionBreakdown
    {
        [JsonProperty("biomass")]
        public double Biomass { get; set; }

        [JsonProperty("coal")]
        public double Coal { get; set; }

        [JsonProperty("gas")]
        public double Gas { get; set; }
        
        [JsonProperty("hydro")]
        public double Hydro { get; set; }

        [JsonProperty("nuclear")]
        public double Nuclear { get; set; }

        [JsonProperty("oil")]
        public double Oil { get; set; }

        [JsonProperty("solar")]
        public double Solar { get; set; }

        [JsonProperty("wind")]
        public double Wind { get; set; }

        [JsonProperty("geothermal")]
        public double Geothermal { get; set; }

        [JsonProperty("hydro-discharge")]
        public double HydroDischarge { get; set; }

        [JsonProperty("hydro-charge")]
        public double HydroCharge { get; set; }

        [JsonProperty("unknown")]
        public double Unknown { get; set; }
    }
}