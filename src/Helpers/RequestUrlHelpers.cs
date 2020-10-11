using System;
using WaybackMachine.DotNet.Client.Constants;
using WaybackMachine.DotNet.Client.Extensions;

namespace Helpers
{
    /// <summary>
    /// Helpers used to construct request
    /// URL's for the API.
    /// </summary>
    public static class RequestUrlHelpers
    {
        /// <summary>
        /// Construct the request url with
        /// the needed parameter for the API.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string ConstructRequest(string area, string? action)
        => string.Concat(ApiConstants.BaseUrl, ApiConstants.Version3, area, action);

        /// <summary>
        /// Builds the request url used for
        /// getting snapshot close to a specific timestamp.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ConstructRequestWithTimestamp(string url, DateTime date) 
        => string.Concat(UrlConstants.UrlExtension, url, UrlConstants.TimeStamp, date.ToWaybackMachineDate());
    }
}