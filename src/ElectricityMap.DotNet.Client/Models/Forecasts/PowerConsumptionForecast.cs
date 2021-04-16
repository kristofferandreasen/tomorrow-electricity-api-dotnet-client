using ElectricityMap.DotNet.Client.Models.Breakdown;
using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    public class PowerConsumptionForecast : BaseDatetime
    {
        [JsonProperty("powerConsumptionBreakdown")]
        public PowerConsumptionBreakdown PowerConsumptionBreakdown { get; set; } = default!;

        [JsonProperty("powerConsumptionTotal")]
        public int PowerConsumptionTotal { get; set; }
    }
}