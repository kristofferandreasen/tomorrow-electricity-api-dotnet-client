﻿using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    /// <summary>
    /// The forecasted carbon intensity (in gCO2eq/kWh) of an area.
    /// </summary>
    public class ForecastedCarbonIntensity : BaseForecast
    {
        [JsonProperty("forecast")]
        public IEnumerable<Forecast> Forecast { get; set; } = default!;
    }
}