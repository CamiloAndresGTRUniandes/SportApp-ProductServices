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
        public async Task<IActionResult> GetAllNutritionTypesAsync(CancellationToken cancellationToken)
        {
            var query = new GetAllGoalsQuery();
            var countries = await mediator.Send(query, cancellationToken);
            return Ok(ResponseGetAllReferential.MapResponse(countries));
        }
    }
