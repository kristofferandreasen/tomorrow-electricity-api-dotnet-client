using System;
using Xunit;

namespace ElectricityMap.DotNet.Client.Helpers
{
    public class RequestUrlHelpersTest
    {
        [Theory]
        [InlineData(ApiAreas)]
        public void Test1(string area)
        {
            RequestUrlHelpers.ConstructRequest(area);
        }
    }
}
