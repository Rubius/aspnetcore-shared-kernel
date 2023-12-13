using System.Net;
using System.Runtime.Serialization;

namespace Rubius.SharedKernel.Domain.Exceptions;

/// <summary>
/// Исключение Shared Kernel
/// </summary>
[Serializable]
public abstract class SharedKernelException : Exception
{
    protected SharedKernelException(
        string message,
        Exception? innerException = null,
        HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError) : base(message, innerException)
    {
        StatusCode = (int)httpStatusCode;
    }

    protected SharedKernelException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    /// <summary>
    /// Статус код
    /// </summary>
    public int StatusCode { get; }
}