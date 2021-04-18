using System.Collections.Generic;
using ElectricityMap.DotNet.Client.Models.Common;
using Newtonsoft.Json;

namespace ElectricityMap.DotNet.Client.Models.Forecasts
{
    /// <summary>
    /// The forecasted marginal carbon intensity (in gCO2eq/kWh) of an area.
    /// </summary>
    public class ForecastedMarginalCarbonIntensity : BaseForecast
    {
        [JsonProperty("forecast")]
        public IEnumerable<MarginalForecast> Forecast { get; set; } = default!;
    }
}
