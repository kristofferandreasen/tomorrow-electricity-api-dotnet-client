using AutoFixture.Xunit2;
using ElectricityMap.DotNet.Client.Http;
using FluentAssertions;
using System;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.Http
{
    public class ElectricityMapHttpFacadeTests
    {
        [Fact]
        public void No_key_throws_exception()
            => Assert
            .Throws<ArgumentNullException>(() => new ElectricityMapHttpFacade(null));

        [Theory, AutoData]
        public void Http_facade_is_created(
            string apiKey)
        {
            var sut = new ElectricityMapHttpFacade(apiKey);

            sut.Should().NotBeNull();
        }
    }
}