using ElectricityMap.DotNet.Client.Models.Updates;
using System;
using System.Collections.Generic;

namespace ElectricityMap.DotNet.Client.Test.ElectricityMapClientTests.Updates
{
    public class UpdateInfoDataFactory
    {
        public UpdatedSince GetUpdateInfoData()
        {
            var update1 = new Update
            {
                Datetime = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            var update2 = new Update
            {
                Datetime = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            var updatedSinceData = new UpdatedSince
            {
                Zone = "DK-DK1",
                Threshold = "P0D1",
                Updates = new List<Update>() { update1, update2 },
                Limit = 100,
                LimitReached = false
            };

            return updatedSinceData;
        }
    }
}