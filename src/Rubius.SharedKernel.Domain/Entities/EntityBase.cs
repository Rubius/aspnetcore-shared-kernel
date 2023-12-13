namespace Rubius.SharedKernel.Domain.Entities;

/// <summary>
/// Базовая сущность
/// </summary>
/// <typeparam name="T">Тип идентификатора</typeparam>
public abstract class EntityBase<T> where T : struct
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public T Id { get; protected set; }
}