using System.Runtime.Serialization;

namespace Rubius.SharedKernel.Domain.Exceptions;

/// <summary>
/// Исключение в слое Domain
/// </summary>
[Serializable]
public class DomainException : SharedKernelException
{
    public DomainException(string message, Exception? innerException = null) : base(message, innerException)
    {
    }

    protected DomainException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}