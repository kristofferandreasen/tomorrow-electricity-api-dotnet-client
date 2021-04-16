using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.History
{
    public class CarbonIntensityHistory : BaseDatetime
    {
        [JsonProperty("carbonIntensity")]
        public int CarbonIntensity { get; set; }
    }
}