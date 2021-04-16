using Newtonsoft.Json;
using System;

namespace ElectricityMap.DotNet.Client.Models.Common
{
    public class BaseForecast : BaseZone
    {
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}