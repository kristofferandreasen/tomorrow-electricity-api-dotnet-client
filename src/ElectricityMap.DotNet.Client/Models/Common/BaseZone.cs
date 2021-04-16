using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Common
{
    public class BaseZone
    {
        [JsonProperty("zone")]
        public string Zone { get; set; } = default!;
    }
}