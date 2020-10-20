using ElectricityMap.DotNet.Client.Constants;
using ElectricityMap.DotNet.Client.Models;
using System;

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
        public static string ConstructRequest(string area)
        => string.Concat(ApiConstants.BaseUrl, ApiConstants.Version3, area);

        /// <summary>
        /// Construct the request needed to
        /// query data by zone.
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        /// <param name="zone"></param>
        /// <returns></returns>
        public static string ConstructRequest(string area, string action, string zone)
        => string.Concat(ApiConstants.BaseUrl, ApiConstants.Version3, area, action, ApiConstants.ZoneParameter, zone);

        /// <summary>
        /// Construct the request with added
        /// datetime for certain api routes.
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        /// <param name="zone"></param>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string ConstructRequest(string area, string action, string zone, DateTime dateTime)
        => string.Concat(ApiConstants.BaseUrl, ApiConstants.Version3, area, action, ApiConstants.ZoneParameter, zone, ApiConstants.DateParameter, dateTime.ToString("o"));

        /// <summary>
        /// Construct the request url with latitude
        /// and longitude as parameters.
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        public static string ConstructRequest(string area, string action, double latitude, double longitude)
        => string.Concat(ApiConstants.BaseUrl, ApiConstants.Version3, area, action, ApiConstants.LatitudeParameter, latitude, ApiConstants.LongitudeParameter, longitude);

        /// <summary>
        /// Construct the request with
        /// latitude and longitude along with
        /// the datetime query for certain routes.
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string ConstructRequest(string area, string action, double latitude, double longitude, DateTime dateTime)
        => string.Concat(ApiConstants.BaseUrl, ApiConstants.Version3, area, action, ApiConstants.LatitudeParameter, latitude, ApiConstants.LongitudeParameter, longitude, ApiConstants.DateParameter, dateTime.ToString("o"));

        /// <summary>
        /// Construct the request to retrieve
        /// information on data updates.
        /// </summary>
        /// <param name="updatedSinceRequest"></param>
        /// <returns></returns>
        public static string ConstructRequest(UpdatedSinceRequest updatedSinceRequest)
        {
            string initialUrl = string.Concat(ApiConstants.BaseUrl, ApiConstants.Version3, ApiAreas.UpdatedSince);
            string queryUrl;

            if (!string.IsNullOrEmpty(updatedSinceRequest.Zone))
            {
                queryUrl = string.Concat(initialUrl, ApiConstants.ZoneParameter, updatedSinceRequest.Zone);
                queryUrl = BuildQueryString(updatedSinceRequest, queryUrl);

                return queryUrl;
            }

            if (updatedSinceRequest.Latitude != null && updatedSinceRequest.Longitude != null)
            {
                queryUrl = string.Concat(initialUrl, ApiConstants.LatitudeParameter, updatedSinceRequest.Latitude, ApiConstants.LongitudeParameter, updatedSinceRequest.Longitude);
                queryUrl = BuildQueryString(updatedSinceRequest, queryUrl);

                return queryUrl;
            }

            throw new Exception("Zone or Latitude/Longitude must be passed as parameters.");
        }

        /// <summary>
        /// Build the query string parameters
        /// for the updated since request.
        /// </summary>
        /// <param name="updatedSinceRequest"></param>
        /// <param name="queryUrl"></param>
        /// <returns></returns>
        private static string BuildQueryString(UpdatedSinceRequest updatedSinceRequest, string queryUrl) 
        {
            if (updatedSinceRequest.Start != null)
                queryUrl = queryUrl + "&start=" + updatedSinceRequest.Start;

            if (updatedSinceRequest.End != null)
                queryUrl = queryUrl + "&end=" + updatedSinceRequest.End;

            if (updatedSinceRequest.Limit != null)
                queryUrl = queryUrl + "&limit=" + updatedSinceRequest.Limit;

            if (updatedSinceRequest.Threshold != null)
                queryUrl = queryUrl + "&threshold=" + updatedSinceRequest.Threshold;

            return queryUrl;
        }
    }
}