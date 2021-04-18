using System;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Common
{
    public class BaseBreakdown : BaseEntity
    {
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}
