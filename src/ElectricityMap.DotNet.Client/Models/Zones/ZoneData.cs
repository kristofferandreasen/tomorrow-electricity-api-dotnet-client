using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Zones
{
    /// <summary>
    /// The zones available for an auth token.
    /// </summary>
    public class ZoneData
    {
        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("zoneName")]
        public string ZoneName { get; set; }

        [JsonProperty("access")]
        public string[] Access { get; set; }
    }
}