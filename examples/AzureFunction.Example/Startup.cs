using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client;

[assembly: FunctionsStartup(typeof(AzureFunction.Example.Startup))]

namespace AzureFunction.Example
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddLogging();

            // Register the electricity map client
            builder.Services.AddSingleton<IElectricityMapClient, ElectricityMapClient>();
        }
    }
}