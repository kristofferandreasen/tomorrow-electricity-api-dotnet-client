using ElectricityMap.DotNet.Client.Models.Breakdown;
using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    public class MarginalPowerForecast : BaseDatetime
    {
        [JsonProperty("marginalPowerConsumptionBreakdown")]
        public MarginalPowerConsumptionBreakdown MarginalPowerConsumptionBreakdown { get; set; } = default!;
    }
}