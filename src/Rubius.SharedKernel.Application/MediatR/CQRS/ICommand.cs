using MediatR;

namespace Rubius.SharedKernel.Application.MediatR.CQRS;

/// <summary>
/// Команда
/// </summary>
public interface ICommand : IRequest
{
}

/// <summary>
/// Команда
/// </summary>
/// <typeparam name="TResponse">Тип ответа</typeparam>
public interface ICommand<out TResponse> : IRequest<TResponse>
{
}