using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.Updates
{
    public class UpdateInfoTests
    {
        [Fact]
        public async void Get_update_info_returns_data()
        {
            var testFactory = new UpdateInfoTestFactory();
            IElectricityMapClient electricityClient = testFactory.SetupUpdateInfoMock();

            var updateRequest = new UpdatedSinceRequest 
            {
                Threshold = "PT0H0M0S"
            };

            UpdatedSince response = await electricityClient.GetUpdateInfoAsync(updateRequest);

            Assert.NotNull(response);
        }
    }
}