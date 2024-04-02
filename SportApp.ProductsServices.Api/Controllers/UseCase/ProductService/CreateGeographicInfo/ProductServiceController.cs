namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateGeographicInfo ;
using System.Diagnostics.CodeAnalysis;
using Domain.ProductService.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Middleware;

    [Route("api/v1/productService")]
    [ApiController]
    public class ProductServiceController(
        [NotNull] IMediator mediator
        ) : ControllerBase
    {
        [HttpPost]
        [Route("geographic")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateGeographicInfoAsync([FromBody] RequestCreateGeographicInfo request, CancellationToken cancellationToken)
        {
            var command = new CreateGeographicInfoCommand
            {
                Id = Guid.NewGuid(),
                CityId = request.CityId,
                CountryId = request.CountryId,
                StateId = request.StateId,
                UserId = request.UserId
            };
            await mediator.Send(command, cancellationToken);
            return NoContent();
        }
    }
