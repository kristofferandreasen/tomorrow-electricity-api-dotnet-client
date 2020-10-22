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

            string url = req.Query["url"];

            var snapshot = await _electricityMapClient.GetMostRecentSnapshotAsync(url);

            return snapshot != null
                ? (ActionResult)new OkObjectResult(snapshot)
                : new BadRequestObjectResult("Please pass a url on the query string or in the request body");
        }
    }
}
