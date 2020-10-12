using System;

namespace ElectricityMap.DotNet.Client.Models
{
    public class UpdatedSinceRequest
    {
        public string Zone { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public DateTime Since { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int? Limit { get; set; }
        public string Threshold { get; set; }
    }
}