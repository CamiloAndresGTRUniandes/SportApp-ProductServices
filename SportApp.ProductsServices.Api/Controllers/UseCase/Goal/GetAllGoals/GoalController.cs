namespace SportApp.ProductsServices.Api.Controllers.UseCase.Goal.GetAllGoals ;

using System.Diagnostics.CodeAnalysis;
using Domain.Goals.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Middleware;
using ProductService.GetGeographicComplementary;

    [Route("api/v1/goal")]
    [ApiController]
    public class GoalController(
        [NotNull] IMediator mediator
        ) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseGetAllReferential>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllGoalsAsync(CancellationToken cancellationToken)
        {
            var query = new GetAllGoalsQuery();
            var goals = await mediator.Send(query, cancellationToken);
            return Ok(ResponseGetAllReferential.MapResponse(goals));
        }

        [HttpGet]
        [Route("{id:guid}")]
        [ProducesResponseType(typeof(List<ResponseGetAllReferential>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetGoalByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var query = new GetGoalByIdQuery
            {
                Id = id
            };
            var goal = await mediator.Send(query, cancellationToken);
            return Ok(ResponseGetAllReferential.MapResponse(goal));
        }
    }
