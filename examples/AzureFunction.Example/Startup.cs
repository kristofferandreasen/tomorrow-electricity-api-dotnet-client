using Microsoft.Extensions.DependencyInjection;
using System;
using ElectricityMap.DotNet.Client.Infrastructure;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(AzureFunction.Example.Startup))]

namespace AzureFunction.Example
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddLogging();

            // Register the electricity map client with your api key
            string electricityMapApiKey = Environment.GetEnvironmentVariable("ElectricityMapApiKey");
            builder.Services.AddElectricityMapClient(electricityMapApiKey);
        }
    }
}