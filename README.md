<div align="center">
  <h1>⚡ Tomorrow Electricity Map API C# .NET Rest Client ⚡</h1>
</div>
<div align="center">
  This API wrapper is built to make it easier to use the ELectricity Map API from Tomorrow.
  It provides a simple interface to understand and optimize the carbon footprint of electricity.
</div>

<br />

<div align="center">
  <a href="https://www.nuget.org/packages/ElectricityMap.DotNet.Client/">
    <img src="https://img.shields.io/nuget/v/ElectricityMap.DotNet.Client"
      alt="NuGet Package" />
  </a>
  <a href="https://github.com/kristofferandreasen/tomorrow-electricity-api-dotnet-client/actions">
    <img src="https://github.com/kristofferandreasen/tomorrow-electricity-api-dotnet-client/workflows/build/badge.svg"
      alt="Build status" />
  </a>
  <a href="https://sonarcloud.io/dashboard?id=kristofferandreasen_wayback-machine-csharp-sdk">
    <img src="https://sonarcloud.io/api/project_badges/measure?project=kristofferandreasen_wayback-machine-csharp-sdk&metric=alert_status"
      alt="Sonar Gate" />
  </a>
  <a href="https://github.com/kristofferandreasen/tomorrow-electricity-api-dotnet-client/issues">
    <img src="https://img.shields.io/github/issues/kristofferandreasen/tomorrow-electricity-api-dotnet-client"
      alt="GitHub Issues" />
  </a>
  <a href="https://opensource.org/licenses/MIT">
    <img src="https://img.shields.io/badge/License-MIT-yellow.svg"
      alt="MIT License" />
  </a>
</div>

<div align="center">
  <h3>
    <a href="https://www.nuget.org/packages/ElectricityMap.DotNet.Client/">
      NuGet Package Download
    </a>
    <span> | </span>
    <a href="https://github.com/kristofferandreasen/tomorrow-electricity-api-dotnet-client#contributing">
      Contributing
    </a>
    <span> | </span>
    <a href="http://static.electricitymap.org/api/docs/index.html">
      Electricity Map API Documentation
    </a>
  </h3>
</div>

<div align="center">
  <sub>A C# .NET Core REST client for the ElectricityMap API. Built with ❤︎ by
  <a href="https://github.com/kristofferandreasen">Kristoffer Andreasen</a>
</div>

## Installation

You need to install the NuGet Package to use the library.
You can use on of the following ways are install it through Visual Studio.

### Install with Package Manager

```
Install-Package ElectricityMap.DotNet.Client
```

### Install with .NET CLI

```
dotnet add package ElectricityMap.DotNet.Client
```

## Available Methods

There is one method available for each of the endpoints provided by the Electricity Map API.
The following table will show you all of them and the parameters needed.

| Method  | Description  |
|:---|:---|
| GetAvailableZonesAsync  | Get the available zones for your API Key.  |
| GetLiveCarbonIntensityAsync  | Data on the live carbon intensity.  |
| GetLivePowerBreakdownAsync  | Live breakdown of the power usage.  |
| GetRecentCarbonIntensityHistoryAsync  | Get data for recent carbon intensity measurements.  |
| GetRecentPowerBreakdownHistoryAsync  | Get data for recent power breakdown measurements.  |
| GetPastCarbonIntensityHistoryAsync  | Get data for past carbon intensity measurements.  |
| GetPastPowerBreakdownHistoryAsync  | Get data for past power breakdown measurements.  |
| GetForecastedCarbonIntensityAsync  | Get data for forecasted carbon intensity measurements.  |
| GetForecastedPowerConsumptionBreakdownAsync  | Get data for forecasted power breakdown measurements.  |
| GetForecastedMarginalCarbonIntensityAsync  | Get data for forecasted marginal carbon intensity measurements.  |
| GetForecastedMarginalPowerConsumptionBreakdownAsync  | Get data for forecasted marginal power breakdown measurements.  |
| GetUpdateInfoAsync  | Get data for API update history.  |

## Using the package

The easiest way to use the library is by using dependency injection.
In the following sections you can see the easiest ways to use the library.

### Dependency Injection: .NET Core Web Application

* Register the WaybackMachine.DotNet.Client interface in the startup file
* Inject the service in the class where you want to use it
* [See full example in Example folder](https://github.com/kristofferandreasen/tomorrow-electricity-api-dotnet-client/tree/master/examples/RazorPages.Example)

```
public void ConfigureServices(IServiceCollection services)
{
    services.AddRazorPages();

    // Register the wayback machine client
    services.AddSingleton<IElectricityMapClient, ElectricityMapClient>();
}
```

```
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

        public LiveCarbonIntentsity CarbonIntensity { get; set; }

        public async Task OnGet()
        {
            CarbonIntensity = await _electricityMapClient.GetLiveCarbonIntensityAsync(ZoneConstants.DK-DK1);
        }
    }
}
```

### Dependency Injection: Azure Function

The pattern for using dependency injection in an Azure Function is similar to a web application.

* Create a startup.cs file to enable dependency injection
* Register the WaybackMachine.DotNet.Client interface in the startup file
* Inject the service in the class where you want to use it
* [See full example in Example folder](https://github.com/kristofferandreasen/tomorrow-electricity-api-dotnet-client/tree/master/examples/AzureFunction.Example)

#### Startup.cs file

```
[assembly: FunctionsStartup(typeof(Azure.Function.Example.Startup))]
namespace Azure.Function.Example
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient();
            builder.Services.AddLogging();

            // Register the wayback machine client
            builder.Services.AddSingleton<IElectricityMapClient, ElectricityMapClient>();
        }
    }
}
```
#### GetSnapshotFunction.cs file

```
public class GetSnapshotFunction
{
    private readonly IElectricityMapClient _electricityMapClient;

    public GetSnapshotFunction(IElectricityMapClient electricityMapClient)
    {
        _electricityMapClient = electricityMapClient;
    }

    [FunctionName(nameof(GetSnapshotFunction))]
    public  async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");

        string zone = req.Query["zone"];

        var carbonIntensity = await _waybackMachineService.GetMostRecentSnapshotAsync(zone);

        return carbonIntensity != null
            ? (ActionResult)new OkObjectResult(carbonIntensity)
            : new BadRequestObjectResult("Please pass a url on the query string or in the request body");
    }
}
```

## Developing

The project is developed as a .NET Core Class Library.
The current framework version used is .NET Core 3.1.

To start developing, you need to clone the repo on your local workstation.

#### Restore Dependencies

```
dotnet restore
```

#### Run Project

```
dotnet run
```

#### Test Project

The project is using XUnit for testing.

```
dotnet test
```

This will start up the development server allowing you to see the results.
Be aware that the solution is setting a cookie and this cookie will be stored in your browser.
In order to see the banner again, you will need to open the localhost link in incognito or clear your browser cookies.

## Contributing

Your contributions are always welcome!
Please have a look at the [contribution guidelines](https://github.com/kristofferandreasen/tomorrow-electricity-api-dotnet-client/blob/master/CONTRIBUTING.md) first 🎉

## License

MIT © [kristofferandreasen](https://github.com/kristofferandreasen)