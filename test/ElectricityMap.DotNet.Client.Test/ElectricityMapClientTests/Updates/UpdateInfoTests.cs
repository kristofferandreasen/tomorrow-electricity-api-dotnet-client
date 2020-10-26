using ElectricityMap.DotNet.Client.Interfaces;
using ElectricityMap.DotNet.Client.Models;
using ElectricityMap.DotNet.Client.Models.Updates;
using System;
using Xunit;

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
                Zone = "DK-DK1",
                Threshold = "PT0H0M0S",
                Since = DateTime.Now.AddYears(-2)
            };

            UpdatedSince response = await electricityClient.GetUpdateInfoAsync(updateRequest);

            Assert.NotNull(response);
        }
    }
}