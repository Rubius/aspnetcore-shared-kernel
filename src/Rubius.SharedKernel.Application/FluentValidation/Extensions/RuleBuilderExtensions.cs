using FluentValidation;
using Rubius.SharedKernel.Application.FluentValidation.Constants;
using Rubius.SharedKernel.Application.FluentValidation.Exceptions;

namespace Rubius.SharedKernel.Application.FluentValidation.Extensions;

public static class RuleBuilderExtensions
{
    /// <summary>
    /// Являются ли уникальными
    /// </summary>
    public static IRuleBuilderOptions<T, TProperty> IsUnique<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder)
        where TProperty : IEnumerable<object>
    {
        var hashSet = new HashSet<object>();

        return ruleBuilder.Must(items => items.All(hashSet.Add))
            .WithMessage("'{PropertyName}' is not unique");
    }

    /// <summary>
    /// Имеет ли уникальные идентификаторы
    /// </summary>
    /// <remarks>
    /// Применимо к тем, у кого существует свойство 'Id'
    /// </remarks>
    /// <exception cref="PropertyNotExistException">Свойство 'Id' не существует</exception>
    public static IRuleBuilderOptions<T, TProperty> HasUniqueIds<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder)
        where TProperty : IEnumerable<object>
    {
        var genericArgument = typeof(TProperty).GetGenericArguments()[0];
        var propertyInfo = genericArgument.GetProperty(PropertyNameConstants.Id) ??
                       throw new PropertyNotExistException(
                           $"Property '{PropertyNameConstants.Id}' does not exist in {genericArgument.Name}");

        var hashSet = new HashSet<object>();

        return ruleBuilder.Must(items =>
                items.All(item => hashSet.Add(propertyInfo.GetValue(item)!)))
            .WithMessage("'{PropertyName}' does not have unique Id's");
    }
}