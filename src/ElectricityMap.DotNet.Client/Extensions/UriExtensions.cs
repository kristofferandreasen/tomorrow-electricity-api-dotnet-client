using System;

namespace ElectricityMap.DotNet.Client.Extensions
{
    public static class UriExtensions
    {
        public static Uri ToUri(this string path)
            => new Uri(path, UriKind.Absolute);
    }
}
