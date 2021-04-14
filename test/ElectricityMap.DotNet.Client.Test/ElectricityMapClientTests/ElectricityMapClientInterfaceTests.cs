using AutoFixture.Xunit2;
using ElectricityMap.DotNet.Client.Interfaces;
using FluentAssertions;
using System;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests
{
    public class ElectricityMapClientInterfaceTests
    {
        [Theory, AutoData]
        public void Should_implement(ElectricityMapClient sut)
            => sut.Should().BeAssignableTo<IElectricityMapClient>();

        [Fact]
        public void No_key_throws_exception()
            => Assert
            .Throws<ArgumentNullException>(() => new ElectricityMapClient(null));

        [Theory, AutoData]
        public void Provided_key_creates_client(string apiKey)
        {
            var sut = new ElectricityMapClient(apiKey);

            sut.Should().NotBeNull();
        }
    }
}