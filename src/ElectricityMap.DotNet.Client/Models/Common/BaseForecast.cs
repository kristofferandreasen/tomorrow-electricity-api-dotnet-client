using System;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Common
{
    public class BaseForecast : BaseZone
    {
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
