using System;

namespace ElectricityMap.DotNet.Client.Models
{
    public class UpdatedSinceRequest
    {
        /// <summary>
        /// Gets or sets the zone identifier.
        /// </summary>
        public string? Zone { get; set; } = default!;

        /// <summary>
        /// Gets or sets longitude (if querying with a geolocation).
        /// </summary>
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or sets latitude (if querying with a geolocation).
        /// </summary>
        public double? Latitude { get; set; }

        public DateTime Since { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        public int? Limit { get; set; }

        /// <summary>
        /// Gets or sets duration in ISO 8601 format.
        /// Example: PT0H0M0S.
        /// </summary>
        public string? Threshold { get; set; }
    }
}
