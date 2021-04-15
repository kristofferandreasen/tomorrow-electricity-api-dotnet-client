using ElectricityMap.DotNet.Client.Http;
using ElectricityMap.DotNet.Client.Interfaces;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests
{
    public class ElectricityMapClientInterfaceTests
    {
        private readonly IElectricityMapHttpFacade httpFacade;

        public ElectricityMapClientInterfaceTests()
        {
            httpFacade = Substitute.For<IElectricityMapHttpFacade>();
        }

        [Fact]
        public void Client_can_be_created()
        {
            var sut = new ElectricityMapClient(httpFacade);

            sut.Should().BeAssignableTo<IElectricityMapClient>();
        }
    }
}