namespace SportApp.ProductsServices.Api.Controllers.UseCase.Goal.CreateGoal ;

using System.Diagnostics.CodeAnalysis;
using Domain.Goals.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Middleware;

    [Route("api/v1/goals")]
    [ApiController]
    public class GoalController(
        [NotNull] IMediator mediator
        ) : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateGoalAsync([FromBody] RequestCreateGoal request, CancellationToken cancellationToken)
        {
            var command = new CreateGoalCommand
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                User = request.User
            };
            await mediator.Send(command, cancellationToken);
            return NoContent();
        }
    }
