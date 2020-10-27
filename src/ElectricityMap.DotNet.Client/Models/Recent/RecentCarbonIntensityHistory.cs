﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Recent
{
    /// <summary>
    /// The last 24h of carbon intensity (in gCO2eq/kWh) of an area.
    /// </summary>
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