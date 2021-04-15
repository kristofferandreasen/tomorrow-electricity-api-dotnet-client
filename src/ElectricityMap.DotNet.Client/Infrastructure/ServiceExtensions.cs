using ElectricityMap.DotNet.Client.Http;
using ElectricityMap.DotNet.Client.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ElectricityMap.DotNet.Client.Infrastructure
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddElectricityMapClient(this IServiceCollection services, string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentNullException(nameof(apiKey));
            }

            services.AddSingleton<IElectricityMapHttpFacade>(s => new ElectricityMapHttpFacade(apiKey));
            services.AddSingleton<IElectricityMapClient, ElectricityMapClient>();

            return services;
        }
    }
}