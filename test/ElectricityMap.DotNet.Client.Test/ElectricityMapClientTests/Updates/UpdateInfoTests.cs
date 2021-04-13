using AutoFixture.Xunit2;
using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models;
using ElectricityMap.DotNet.Client.Models.Updates;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.Updates
{
    public class UpdateInfoTests
    {
        private readonly IElectricityMapClient sut;

        public UpdateInfoTests()
        {
            sut = Substitute.For<IElectricityMapClient>();
        }

        [Theory, AutoData]
        public async void Get_update_info_returns_data(
            UpdatedSinceRequest updatedSinceRequest,
            UpdatedSince updatedSince)
        {
            sut
                .GetUpdateInfoAsync(Arg.Any<UpdatedSinceRequest>())
                .Returns(updatedSince);

            var result = await sut
                 .GetUpdateInfoAsync(updatedSinceRequest);

            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(updatedSince);
        }
    }
}