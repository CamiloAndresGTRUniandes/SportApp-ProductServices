namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.GetComplementaryInformation ;

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

        [HttpGet]
        [Route("Category")]
        [ProducesResponseType(typeof(List<ResponseGetAllReferential>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllCategoriesAsync(CancellationToken cancellationToken)
        {
            var query = new GetAllCategoriesQuery();
            var countries = await mediator.Send(query, cancellationToken);
            return Ok(ResponseGetAllReferential.MapResponse(countries));
        }

        [HttpGet]
        [Route("ServiceTypeByCategory/{categoryId}")]
        [ProducesResponseType(typeof(List<ResponseGetAllReferential>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCitiesByStateAsync(Guid categoryId, CancellationToken cancellationToken)
        {
            var query = new GetServiceTypeByCategoryQuery { CategoryId = categoryId };
            var states = await mediator.Send(query, cancellationToken);
            return Ok(ResponseGetAllReferential.MapResponse(states));
        }

        [HttpGet]
        [Route("Plan")]
        [ProducesResponseType(typeof(List<ResponseGetAllReferential>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllPlansAsync(CancellationToken cancellationToken)
        {
            var query = new GetAllPlansQuery();
            var states = await mediator.Send(query, cancellationToken);
            return Ok(ResponseGetAllReferential.MapResponse(states));
        }

        [HttpGet]
        [Route("Plan/{planId:guid}")]
        [ProducesResponseType(typeof(List<ResponseGetAllReferential>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPlanByIdAsync(Guid planId, CancellationToken cancellationToken)
        {
            var query = new GetPlanByIdQuery { Id = planId };
            var states = await mediator.Send(query, cancellationToken);
            return Ok(ResponseGetAllReferential.MapResponse(states));
        }


        [HttpGet]
        [Route("ServiceType/{id:guid}")]
        [ProducesResponseType(typeof(List<ResponseGetAllReferential>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetServiceTypeByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var query = new GetServiceTypeByIdQuery { Id = id };
            var states = await mediator.Send(query, cancellationToken);
            return Ok(ResponseGetAllReferential.MapResponse(states));
        }
    }
