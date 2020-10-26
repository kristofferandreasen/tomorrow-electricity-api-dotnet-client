using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models;
using Moq;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.Updates
{
    public class UpdateInfoTestFactory
    {
        private UpdateInfoDataFactory dataFactory = new UpdateInfoDataFactory();

        public IElectricityMapClient SetupUpdateInfoMock()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetUpdateInfoData();

            serviceMoq
                .Setup(o => o.GetUpdateInfoAsync(It.IsAny<UpdatedSinceRequest>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }
    }
}