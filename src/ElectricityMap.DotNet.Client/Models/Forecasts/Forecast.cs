using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    public class Forecast : BaseDatetime
    {
        [JsonProperty("carbonIntensity")]
        public int CarbonIntensity { get; set; }
    }
}