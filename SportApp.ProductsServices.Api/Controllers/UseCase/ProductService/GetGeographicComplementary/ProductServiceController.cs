namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.GetGeographicComplementary ;

using System.Diagnostics.CodeAnalysis;
using Domain.ProductService.Queries;
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
        [Route("AllCountries")]
        [ProducesResponseType(typeof(List<ResponseGetAllReferential>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllCountriesAsync(CancellationToken cancellationToken)
        {
            var query = new GetAllCountryQuery();
            var countries = await mediator.Send(query, cancellationToken);
            return Ok(ResponseGetAllReferential.MapResponse(countries));
        }

        [HttpGet]
        [Route("StatesByCountry/{countryId}")]
        [ProducesResponseType(typeof(List<ResponseGetAllReferential>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetStatesByCountryAsync(Guid countryId, CancellationToken cancellationToken)
        {
            var query = new GetStatesByCountryQuery { CountryId = countryId };
            var states = await mediator.Send(query, cancellationToken);
            return Ok(ResponseGetAllReferential.MapResponse(states));
        }

        [HttpGet]
        [Route("CitiesByState/{stateId}")]
        [ProducesResponseType(typeof(List<ResponseGetAllReferential>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCitiesByStateAsync(Guid stateId, CancellationToken cancellationToken)
        {
            var query = new GetCitiesByStateQuery { StateId = stateId };
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
    }
