using System.Runtime.CompilerServices;

namespace Rubius.SharedKernel.Domain.GuardClauses;

/// <summary>
/// Валидатор входных параметров
/// </summary>
public static class Ensure
{
    /// <summary>
    /// Убедиться, что значение ненулевое
    /// </summary>
    /// <param name="value">Значение</param>
    /// <param name="argumentName">Имя аргумента</param>
    /// <exception cref="ArgumentNullException">Исключение нулевого аргумента</exception>
    public static void NotNull<T>(T value, [CallerArgumentExpression("value")] string? argumentName = null)
        where T : class
    {
        if (value is null)
        {
            throw new ArgumentNullException(argumentName);
        }
    }

    /// <summary>
    /// Убедиться, что значение строки ненулевое или пустое
    /// </summary>
    /// <param name="value">Значение</param>
    /// <param name="argumentName">Имя аргумента</param>
    /// <exception cref="ArgumentException">Исключение аргумента</exception>
    public static void NotNullOrEmpty(string? value, [CallerArgumentExpression("value")] string? argumentName = null)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("The value can't be null or empty", argumentName);
        }
    }

    /// <summary>
    /// Убедиться, что значение строки ненулевое, непустое или не содержит пустое пространство
    /// </summary>
    /// <param name="value">Значение</param>
    /// <param name="argumentName">Имя аргумента</param>
    /// <exception cref="ArgumentException">Исключение аргумента</exception>
    public static void NotNullOrWhiteSpace(string? value, [CallerArgumentExpression("value")] string? argumentName = null)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("The value can't be null, empty or white space", argumentName);
        }
    }
}