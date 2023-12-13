using MediatR;

namespace Rubius.SharedKernel.Application.MediatR.CQRS;

/// <summary>
/// Обработчик запроса
/// </summary>
/// <typeparam name="TQuery">Тип запроса</typeparam>
/// <typeparam name="TResponse">Тип ответа</typeparam>
public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
{
}