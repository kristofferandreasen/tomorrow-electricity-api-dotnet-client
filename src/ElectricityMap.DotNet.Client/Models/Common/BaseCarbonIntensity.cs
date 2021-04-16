using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Common
{
    public class BaseCarbonIntensity : BaseEntity
    {
        [JsonProperty("carbonIntensity")]
        public int CarbonIntensity { get; set; }
    }
}