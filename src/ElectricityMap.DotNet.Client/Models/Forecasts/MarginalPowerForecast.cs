using ElectricityMap.DotNet.Client.Models.Breakdown;
using Newtonsoft.Json;
using System;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    public class MarginalPowerForecast
    {
        [JsonProperty("marginalPowerConsumptionBreakdown")]
        public MarginalPowerConsumptionBreakdown MarginalPowerConsumptionBreakdown { get; set; } = default!;

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }
    }
}