using System;
using System.Threading.Tasks;
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

        [Theory]
        [AutoData]
        public async Task Get_update_info_returns_data_Async(
            UpdatedSinceRequest updatedSinceRequest,
            UpdatedSince updatedSince)
        {
            httpFacade
                .GetAsync<UpdatedSince>(Arg.Any<Uri>())
                .Returns(updatedSince);

            var result = await sut
                 .GetUpdateInfoAsync(updatedSinceRequest)
                 .ConfigureAwait(false);

            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(updatedSince);
        }
    }
}
