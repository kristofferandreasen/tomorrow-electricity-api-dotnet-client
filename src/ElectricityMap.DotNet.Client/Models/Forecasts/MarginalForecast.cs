using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    public class MarginalForecast : BaseDatetime
    {
        [JsonProperty("marginalCarbonIntensity")]
        public int MarginalCarbonIntensity { get; set; }
    }
}