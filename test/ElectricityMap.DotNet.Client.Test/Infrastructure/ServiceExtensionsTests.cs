using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Infrastructure;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;
using ElectricityMap.DotNet.Client.Http;

namespace ElectricityMap.DotNet.Client.Test.Infrastructure
{
    public class ServiceExtensionsTests
    {
        [Theory]
        [InlineAutoNSubstituteData(typeof(IElectricityMapClient))]
        [InlineAutoNSubstituteData(typeof(IElectricityMapHttpFacade))]
        public void Services_should_register(
            Type serviceType)
        {
            var services = new ServiceCollection();
            services.AddElectricityMapClient("ApiKey");

            services
                .Should()
                .Contain(s => s.ServiceType == serviceType);

            services.BuildServiceProvider();
        }
    }
}