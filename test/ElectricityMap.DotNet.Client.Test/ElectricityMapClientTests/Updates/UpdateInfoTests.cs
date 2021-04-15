using AutoFixture.Xunit2;
using ElectricityMap.DotNet.Client.Http;
using ElectricityMap.DotNet.Client.Models;
using ElectricityMap.DotNet.Client.Models.Updates;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.Updates
{
    public class UpdateInfoTests
    {
        private readonly IElectricityMapHttpFacade httpFacade;
        private readonly ElectricityMapClient sut;

        public UpdateInfoTests()
        {
            httpFacade = Substitute.For<IElectricityMapHttpFacade>();
            sut = new ElectricityMapClient(httpFacade);
        }

        [Theory, AutoData]
        public async void Get_update_info_returns_data(
            UpdatedSinceRequest updatedSinceRequest,
            UpdatedSince updatedSince)
        {
            httpFacade
                .GetAsync<UpdatedSince>(Arg.Any<string>())
                .Returns(updatedSince);

            var result = await sut
                 .GetUpdateInfoAsync(updatedSinceRequest);

            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(updatedSince);
        }
    }
}