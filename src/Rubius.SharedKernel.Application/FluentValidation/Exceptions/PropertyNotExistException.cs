using FluentValidation;

namespace Rubius.SharedKernel.Application.FluentValidation.Exceptions;

public class PropertyNotExistException : ValidationException
{
    public PropertyNotExistException(string message) : base(message)
    {
    }
}