namespace SportApp.ProductsServices.Api.Controllers.UseCase.Activity.GetAllActiveActivities ;

using System.Diagnostics.CodeAnalysis;
using Domain.Activities.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Middleware;

    [Route("api/v1/activities")]
    [ApiController]
    public class ActivityController(
        [NotNull] IMediator mediator
        ) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseGetAllActivities>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateActivityAsync(CancellationToken cancellationToken)
        {
            var command = new GetAllActivitiesQuery();
            var activities = await mediator.Send(command, cancellationToken);
            return Ok(ResponseGetAllActivities.MapResponse(activities));
        }
    }
