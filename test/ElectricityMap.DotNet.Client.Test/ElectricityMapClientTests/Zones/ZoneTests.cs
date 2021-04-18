using AutoFixture.Xunit2;
using ElectricityMap.DotNet.Client.Http;
using ElectricityMap.DotNet.Client.Models.Zones;
using FluentAssertions;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.Zones
{
    public class ZoneTests
    {
        private readonly IElectricityMapHttpFacade httpFacade;
        private readonly ElectricityMapClient sut;

        public ZoneTests()
        {
            httpFacade = Substitute.For<IElectricityMapHttpFacade>();
            sut = new ElectricityMapClient(httpFacade);
        }

        [Theory, AutoData]
        public async void Zones_are_available(
            Dictionary<string, ZoneData> zones)
        {
            httpFacade
                .GetAsync<Dictionary<string, ZoneData>>(Arg.Any<Uri>())
                .Returns(zones);

            var result = await sut
                .GetAvailableZonesAsync();

            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(zones);
        }
    }
}
