using Microsoft.Extensions.Logging;
using System.Runtime.Serialization;

namespace Portfolio.Infrastructure.Identity.Authorization
{
    public class AuthorizationException : Exception
    {
        public string Code { get; set; }
        public string Details { get; set; }
        public LogLevel LogLevel { get; set; }

        public AuthorizationException(string? code = null, string? message = null, string? details = null,
                                 Exception innerException = null, LogLevel logLevel = LogLevel.Warning)
            : base(message, innerException) { Code = code; Details = details; LogLevel = logLevel; }

        public AuthorizationException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context) { }

        public AuthorizationException WithData(string name, object value) { Data[name] = value; return this; }

    }
}
