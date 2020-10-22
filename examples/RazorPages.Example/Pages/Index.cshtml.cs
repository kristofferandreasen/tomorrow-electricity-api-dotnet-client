using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public LiveCarbonIntensity CarbonIntensity { get; set; }

        public async Task OnGet()
        {
            CarbonIntensity = await _electricityMapClient.GetLiveCarbonIntensityAsync(ZoneConstants.Denmark_East_Denmark);
        }
    }
}
