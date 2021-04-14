using AutoFixture.Xunit2;
using ElectricityMap.DotNet.Client.Exceptions;
using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models.Zones;
using FluentAssertions;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using System.Collections.Generic;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.Zones
{
    public class ZoneTests
    {
        private readonly IElectricityMapClient sut;

        public ZoneTests()
        {
            sut = Substitute.For<IElectricityMapClient>();
        }

        [Theory, AutoData]
        public async void Zones_are_available(
            Dictionary<string, ZoneData> zones)
        {
            sut
                .GetAvailableZonesAsync()
                .Returns(zones);

            var result = await sut
                .GetAvailableZonesAsync();

            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(zones);
        }
    }
}