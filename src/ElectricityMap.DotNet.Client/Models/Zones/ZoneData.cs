using Newtonsoft.Json;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Zones
{
    /// <summary>
    /// The zones available for an auth token.
    /// </summary>
    public class ZoneData
    {
        [JsonProperty("countryName")]
        public string CountryName { get; set; } = default!;

        [JsonProperty("zoneName")]
        public string ZoneName { get; set; } = default!;

        [JsonProperty("access")]
        public IEnumerable<string> Access { get; set; } = default!;
    }
}