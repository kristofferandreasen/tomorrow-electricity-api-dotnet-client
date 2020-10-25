using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.Updates
{
    public class UpdateInfoTestFactory
    {
        private UpdateInfoDataFactory dataFactory = new UpdateInfoDataFactory();

        public IElectricityMapClient SetupUpdateInfoMock()
        {
            var serviceMoq = new Mock<IElectricityMapClient>();
            var data = dataFactory.GetUpdateInfoDate();

            serviceMoq
                .Setup(o => o.GetUpdateInfoAsync(It.IsAny<UpdatedSinceRequest>()))
                .ReturnsAsync(data);

            return serviceMoq.Object;
        }
    }
}