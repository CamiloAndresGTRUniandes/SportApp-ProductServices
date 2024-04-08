namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.GetTypesOfNutrition ;

using System.Diagnostics.CodeAnalysis;
using Domain.ProductService.Queries;
using GetGeographicComplementary;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Middleware;

    [Route("api/v1/productService")]
    [ApiController]
    public class ProductServiceController(
        [NotNull] IMediator mediator
        ) : ControllerBase
    {
        [HttpGet]
        [Route("TypeOfNutrition")]
        [ProducesResponseType(typeof(List<ResponseGetAllReferential>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllNutritionTypesAsync(CancellationToken cancellationToken)
        {
            var query = new GetAllNutritionTypesQuery();
            var countries = await mediator.Send(query, cancellationToken);
            return Ok(ResponseGetAllReferential.MapResponse(countries));
        }

        [HttpGet]
        [Route("NutritionalAllergy")]
        [ProducesResponseType(typeof(List<ResponseGetAllReferential>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllNutritionalAllergiesAsync(CancellationToken cancellationToken)
        {
            var query = new GetAllNutritionalAllergiesQuery();
            var countries = await mediator.Send(query, cancellationToken);
            return Ok(ResponseGetAllReferential.MapResponse(countries));
        }
    }
