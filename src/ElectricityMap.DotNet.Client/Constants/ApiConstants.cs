namespace ElectricityMap.DotNet.Client.Constants
{
    public static class ApiConstants
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1075:URIs should not be hardcoded", Justification = "Static base url of API")]
        public const string BaseUrl = "https://api.electricitymap.org";

        public const string AuthHeader = "auth-token";

        public const string Version3 = "/v3/";

        public const string ZoneParameter = "?zone=";

        public const string DateParameter = "&datetime=";

        public const string LatitudeParameter = "?lat=";

        public const string LongitudeParameter = "&lon=";
    }
}