using Newtonsoft.Json;
using System;

namespace ElectricityMap.DotNet.Client.Models.Common
{
    public class BaseDatetime
    {
        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }
    }
}