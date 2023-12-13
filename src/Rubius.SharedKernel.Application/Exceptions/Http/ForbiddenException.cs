using System.Net;
using System.Runtime.Serialization;
using Rubius.SharedKernel.Domain.Exceptions;

namespace Rubius.SharedKernel.Application.Exceptions.Http;

/// <summary>
/// Исключение 'Доступ запрещён'
/// </summary>
/// <remarks> Бросается со статус кодом 403 </remarks>
[Serializable]
public class ForbiddenException : SharedKernelException
{
    public ForbiddenException(string message, Exception? innerException = null)
        : base(message, innerException, HttpStatusCode.Forbidden)
    {
    }

    protected ForbiddenException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}