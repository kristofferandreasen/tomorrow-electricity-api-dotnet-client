using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Zones
{
    public class RecentCarbonIntensityHistory
    {
        [JsonProperty("zone")]
        public string Zone { get; set; }

        [JsonProperty("history")]
        public IEnumerable<History> History { get; set; }
    }

    public class History
    {
        [JsonProperty("carbonIntensity")]
        public int CarbonIntensity { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }
    }
}