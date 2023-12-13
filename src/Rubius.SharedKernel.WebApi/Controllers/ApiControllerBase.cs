using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Rubius.SharedKernel.WebApi.Exceptions;

namespace Rubius.SharedKernel.WebApi.Controllers;

/// <summary>
/// Базовый API контроллер
/// </summary>
[Authorize]
[ApiController]
public abstract class ApiControllerBase : ControllerBase
{
    private IMediator? _mediator;

    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>()
                                                  ?? throw new WebApiException("Cannot instantiate the Mediator");
}