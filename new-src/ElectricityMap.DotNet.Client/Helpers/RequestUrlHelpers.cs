using ElectricityMap.DotNet.Client.Constants;

namespace ElectricityMap.DotNet.Client.Helpers
{
    /// <summary>
    /// Helpers used to construct 
    /// request paths for the API.
    /// </summary>
    public static class RequestUrlHelpers
    {
        /// <summary>
        /// Construct the request url with
        /// the needed parameter for the API.
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static string ConstructRequest(string area, string action = "")
        => string.Concat(ApiConstants.BaseUrl, ApiConstants.Version3, area, action);
    }
}