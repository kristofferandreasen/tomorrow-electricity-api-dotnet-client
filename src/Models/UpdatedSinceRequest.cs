using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UpdatedSinceRequest
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
        public string? Threshold { get; set; }
    }
}