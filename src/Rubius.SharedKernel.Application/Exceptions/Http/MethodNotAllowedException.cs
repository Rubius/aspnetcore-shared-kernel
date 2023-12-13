using System.Net;
using System.Runtime.Serialization;
using Rubius.SharedKernel.Domain.Exceptions;

namespace Rubius.SharedKernel.Application.Exceptions.Http;

/// <summary>
/// Исключение 'Метод не поддерживается'
/// </summary>
/// <remarks> Бросается со статус кодом 405 </remarks>
[Serializable]
public class MethodNotAllowedException : SharedKernelException
{
    public MethodNotAllowedException(string message, Exception? innerException = null)
        : base(message, innerException, HttpStatusCode.MethodNotAllowed)
    {
    }

    protected MethodNotAllowedException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}