using System;
using System.Net;

namespace ElectricityMap.DotNet.Client.Exceptions
{
    /// <summary>
    /// Exception thrown when electricity map API returns non success status code.
    /// </summary>
    [Serializable]
    public sealed class ElectricityMapException : Exception
    {
        public ElectricityMapException(HttpStatusCode statusCode)
            => HttpStatusCode = statusCode;

        public ElectricityMapException(HttpStatusCode statusCode, string message) : base(message)
            => HttpStatusCode = statusCode;

        public ElectricityMapException(HttpStatusCode statusCode, string message, Exception innerException) : base(message, innerException)
            => HttpStatusCode = statusCode;

        /// <summary>
        /// Http status code of electricity map response.
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; }
    }
}