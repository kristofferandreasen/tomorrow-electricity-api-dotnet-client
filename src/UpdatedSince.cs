using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Zones
{
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