using System.Runtime.Serialization;
using Rubius.SharedKernel.Domain.Exceptions;

namespace Rubius.SharedKernel.Infrastructure.Exceptions;

/// <summary>
/// Исключение в слое Infrastructure
/// </summary>
[Serializable]
public class InfrastructureException : SharedKernelException
{
    public InfrastructureException(string message, Exception? innerException = null) : base(message, innerException)
    {
    }

    protected InfrastructureException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}