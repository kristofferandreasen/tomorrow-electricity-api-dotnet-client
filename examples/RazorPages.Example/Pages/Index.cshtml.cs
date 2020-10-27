using System.Threading.Tasks;
using ElectricityMap.DotNet.Client.Constants;
using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Live;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPages.Example.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IElectricityMapClient _electricityMapClient;

        public IndexModel(
            ILogger<IndexModel> logger,
            IElectricityMapClient electricityMapClient
        )
        {
            _logger = logger;
            _electricityMapClient = electricityMapClient;
        }

        public LiveCarbonIntensity LiveCarbonIntensity { get; set; }

        public async Task OnGet()
        {
            var data = await _electricityMapClient.GetForecastedMarginalPowerConsumptionBreakdownAsync(ZoneConstants.Denmark_East_Denmark);
        }
    }
}