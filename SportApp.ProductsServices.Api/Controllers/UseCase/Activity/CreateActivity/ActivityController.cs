namespace SportApp.ProductsServices.Api.Controllers.UseCase.Activity.CreateActivity ;

using System.Diagnostics.CodeAnalysis;
using Domain.Activities.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Middleware;

    [Route("api/v1/activities")]
    [ApiController]
    public class ActivityController(
        [NotNull] IMediator mediator
        ) : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateActivityAsync([FromBody] RequestCreateActivity request, CancellationToken cancellationToken)
        {
            var command = new CreateActivityCommand
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                User = request.User
            };
            await mediator.Send(command, cancellationToken);
            return NoContent();
        }
    }
