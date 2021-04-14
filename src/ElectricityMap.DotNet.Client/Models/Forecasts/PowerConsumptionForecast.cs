using ElectricityMap.DotNet.Client.Models.Breakdown;
using Newtonsoft.Json;
using System;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    public class PowerConsumptionForecast
    {
        [JsonProperty("powerConsumptionBreakdown")]
        public PowerConsumptionBreakdown PowerConsumptionBreakdown { get; set; } = default!;

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }

        [JsonProperty("powerConsumptionTotal")]
        public int PowerConsumptionTotal { get; set; }
    }
}