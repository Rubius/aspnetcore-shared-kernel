using System.Runtime.Serialization;

namespace Rubius.SharedKernel.Domain.Exceptions;

/// <summary>
/// Исключение 'Отрицательное значение'
/// </summary>
[Serializable]
public class NegativeValueException : SharedKernelException
{
    public NegativeValueException(string propertyName, Exception? innerException = null)
        : base($"The value of '{propertyName}' cannot be less than zero", innerException)
    {
    }

    protected NegativeValueException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}