using MediatR;

namespace Rubius.SharedKernel.Application.MediatR.CQRS;

/// <summary>
/// Обработчик команды
/// </summary>
/// <typeparam name="TCommand">Тип команды</typeparam>
public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand>
    where TCommand : ICommand
{
}

/// <summary>
/// Обработчик команды
/// </summary>
/// <typeparam name="TCommand">Тип команды</typeparam>
/// <typeparam name="TResponse">Тип ответа</typeparam>
public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
{
}