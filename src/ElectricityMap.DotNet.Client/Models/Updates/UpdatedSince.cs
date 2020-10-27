using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Updates
{
    /// <summary>
    /// A list of timestamps where data has been updated since a specified date for a specified zone. 
    /// </summary>
    public class UpdatedSince
    {
        [JsonProperty("zone")]
        public string Zone { get; set; }

        [JsonProperty("updates")]
        public IEnumerable<Update> Updates { get; set; }

        [JsonProperty("threshold")]
        public string Threshold { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("limitReached")]
        public bool LimitReached { get; set; }
    }

    public class Update
    {
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }
    }
}