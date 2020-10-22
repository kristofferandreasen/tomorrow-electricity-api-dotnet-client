using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunction.Example
{
    public class GetCarbonIntensityFunction
    {
        private readonly IElectricityMapClient _electricityMapClient;

        public GetCarbonIntensityFunction(IElectricityMapClient electricityMapClient)
        {
            _electricityMapClient = electricityMapClient;
        }

        [FunctionName(nameof(GetCarbonIntensityFunction))]
        public  async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string zone = req.Query["zone"];

            var carbonIntensity = await _electricityMapClient.GetLiveCarbonIntensityAsync(zone);

            return carbonIntensity != null
                ? (ActionResult)new OkObjectResult(carbonIntensity)
                : new BadRequestObjectResult("Please pass a zone on the query string or in the request body");
        }
    }
}
