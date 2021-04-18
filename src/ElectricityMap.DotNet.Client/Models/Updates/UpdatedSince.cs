using System.Collections.Generic;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Updates
{
    /// <summary>
    /// A list of timestamps where data has been updated since a specified date for a specified zone.
    /// </summary>
    public class UpdatedSince
    {
        [JsonProperty("zone")]
        public string Zone { get; set; } = default!;

        [JsonProperty("updates")]
        public IEnumerable<Update> Updates { get; set; } = default!;

        [JsonProperty("threshold")]
        public string Threshold { get; set; } = default!;

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("limitReached")]
        public bool LimitReached { get; set; }
    }
}
