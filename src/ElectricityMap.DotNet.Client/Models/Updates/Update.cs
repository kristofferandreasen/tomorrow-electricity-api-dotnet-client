using System;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Updates
{
    public class Update
    {
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }
    }
}
