using FluentValidation;

namespace Rubius.SharedKernel.Application.FluentValidation.Abstractions;

/// <summary>
/// Базовый валидатор
/// </summary>
/// <typeparam name="TValidation">Тип проверяемого объекта</typeparam>
public abstract class ValidatorBase<TValidation> : AbstractValidator<TValidation>
    where TValidation : class
{
}