using System;
using System.Net;
using System.Runtime.Serialization;

namespace ElectricityMap.DotNet.Client.Exceptions
{
    /// <summary>
    /// Exception thrown when electricity map API returns non success status code.
    /// </summary>
    [Serializable]
    public class ElectricityMapException : Exception
    {
        public ElectricityMapException()
        {
        }

        public ElectricityMapException(string message)
            : base(message)
        {
        }

        public ElectricityMapException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ElectricityMapException(HttpStatusCode statusCode)
            => HttpStatusCode = statusCode;

        public ElectricityMapException(HttpStatusCode statusCode, string message)
            : base(message)
            => HttpStatusCode = statusCode;

        public ElectricityMapException(HttpStatusCode statusCode, string message, Exception innerException)
            : base(message, innerException)
            => HttpStatusCode = statusCode;

        protected ElectricityMapException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets http status code of electricity map response.
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; }
    }
}
