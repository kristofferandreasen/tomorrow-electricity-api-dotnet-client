#nullable enable

using System;

namespace ElectricityMap.DotNet.Client.Models
{
    public class UpdatedSinceRequest
    {
        public string? Zone { get; set; } = default!;
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public DateTime Since { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int? Limit { get; set; }

        /// <summary>
        /// Duration in ISO 8601 format.
        /// Example: PT0H0M0S.
        /// </summary>
        public string? Threshold { get; set; }
    }
}