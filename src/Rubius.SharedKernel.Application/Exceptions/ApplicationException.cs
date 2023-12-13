using System.Runtime.Serialization;
using Rubius.SharedKernel.Domain.Exceptions;

namespace Rubius.SharedKernel.Application.Exceptions;

/// <summary>
/// Исключение в слое Application
/// </summary>
[Serializable]
public class ApplicationException : SharedKernelException
{
    public ApplicationException(string message, Exception? innerException = null) : base(message, innerException)
    {
    }

    protected ApplicationException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}