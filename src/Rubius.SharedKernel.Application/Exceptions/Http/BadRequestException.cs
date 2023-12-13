using System.Net;
using System.Runtime.Serialization;
using Rubius.SharedKernel.Domain.Exceptions;

namespace Rubius.SharedKernel.Application.Exceptions.Http;

/// <summary>
/// Исключение 'Неправильный запрос'
/// </summary>
/// <remarks> Бросается со статус кодом 400 </remarks>
[Serializable]
public class BadRequestException : SharedKernelException
{
    public BadRequestException(string message, Exception? innerException = null)
        : base(message, innerException, HttpStatusCode.BadRequest)
    {
    }

    protected BadRequestException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}