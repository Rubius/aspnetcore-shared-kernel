using System.Net;
using System.Runtime.Serialization;
using Rubius.SharedKernel.Domain.Exceptions;

namespace Rubius.SharedKernel.Application.Exceptions.Http;

/// <summary>
/// Исключение 'Не авторизован'
/// </summary>
/// <remarks> Бросается со статус кодом 401 </remarks>
[Serializable]
public class UnauthorizedException : SharedKernelException
{
    public UnauthorizedException(string message, Exception? innerException = null)
        : base(message, innerException, HttpStatusCode.Unauthorized)
    {
    }

    protected UnauthorizedException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}