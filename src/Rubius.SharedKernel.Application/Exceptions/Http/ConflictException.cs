using System.Net;
using System.Runtime.Serialization;
using Rubius.SharedKernel.Domain.Exceptions;

namespace Rubius.SharedKernel.Application.Exceptions.Http;

/// <summary>
/// Исключение 'Конфликт'
/// </summary>
/// <remarks> Бросается со статус кодом 409 </remarks>
[Serializable]
public class ConflictException : SharedKernelException
{
    public ConflictException(string message, Exception? innerException = null)
        : base(message, innerException, HttpStatusCode.Forbidden)
    {
    }

    protected ConflictException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}