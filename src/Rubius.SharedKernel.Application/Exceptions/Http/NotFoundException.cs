using System.Net;
using System.Runtime.Serialization;
using Rubius.SharedKernel.Domain.Exceptions;

namespace Rubius.SharedKernel.Application.Exceptions.Http;

/// <summary>
/// Исключение 'Не найдено'
/// </summary>
/// <remarks> Бросается со статус кодом 404 </remarks>
[Serializable]
public class NotFoundException : SharedKernelException
{
    public NotFoundException(string message, Exception? innerException = null)
        : base(message, innerException, HttpStatusCode.NotFound)
    {
    }

    protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}