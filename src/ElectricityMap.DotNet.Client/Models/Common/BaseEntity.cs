using Newtonsoft.Json;
using System;

namespace ElectricityMap.DotNet.Client.Models.Common
{
    public class BaseEntity : BaseZone
    {
        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}