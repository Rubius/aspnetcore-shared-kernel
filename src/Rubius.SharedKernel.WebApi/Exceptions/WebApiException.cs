using System.Runtime.Serialization;
using Rubius.SharedKernel.Domain.Exceptions;

namespace Rubius.SharedKernel.WebApi.Exceptions;

/// <summary>
/// Исключение в слое WebApi
/// </summary>
[Serializable]
public class WebApiException : SharedKernelException
{
    public WebApiException(string message, Exception? innerException = null) : base(message, innerException)
    {
    }

    protected WebApiException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}