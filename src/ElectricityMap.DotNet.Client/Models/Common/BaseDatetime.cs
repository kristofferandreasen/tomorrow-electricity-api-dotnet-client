using System;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Common
{
    public class BaseDatetime
    {
        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }
    }
}
