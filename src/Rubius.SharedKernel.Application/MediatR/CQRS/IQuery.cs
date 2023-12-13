using MediatR;

namespace Rubius.SharedKernel.Application.MediatR.CQRS;

/// <summary>
/// Запрос
/// </summary>
/// <typeparam name="TResponse">Тип ответа</typeparam>
public interface IQuery<out TResponse> : IRequest<TResponse>
{
}