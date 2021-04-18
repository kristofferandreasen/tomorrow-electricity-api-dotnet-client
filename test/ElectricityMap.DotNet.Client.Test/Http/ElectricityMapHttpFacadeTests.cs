using System;
using AutoFixture.Xunit2;
using ElectricityMap.DotNet.Client.Exceptions;
using ElectricityMap.DotNet.Client.Http;
using ElectricityMap.DotNet.Client.Models.Zones;
using FluentAssertions;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.Http
{
    public class ElectricityMapHttpFacadeTests
    {
        [Fact]
        public void No_key_throws_exception()
            => Assert
            .Throws<ArgumentNullException>(() => new ElectricityMapHttpFacade(null));

        [Theory]
        [AutoData]
        public void Http_facade_is_created(
            string apiKey)
        {
            var sut = new ElectricityMapHttpFacade(apiKey);

            sut.Should().NotBeNull();
        }

        [Fact]
        public void No_url_throws_exception()
        {
            _ = Assert
               .ThrowsAsync<ElectricityMapException>(() =>
               new ElectricityMapHttpFacade("ApiKey")
               .GetAsync<ZoneData>(new Uri(string.Empty)));
        }

        [Fact]
        public void Random_url_throws_exception()
        {
            _ = Assert
               .ThrowsAsync<ElectricityMapException>(() =>
               new ElectricityMapHttpFacade("ApiKey")
               .GetAsync<ZoneData>(new Uri("www.test.com")));
        }
    }
}
