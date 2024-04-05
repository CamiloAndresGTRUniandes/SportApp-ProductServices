namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.GetServiceType ;
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
        [HttpGet]
        [Route("getActiveServiceTypes")]
        [ProducesResponseType(typeof(List<ResponseGetServiceTypes>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetActiveServiceTypesAsync(CancellationToken cancellationToken)
        {
            var command = new GetServiceTypesCommand { Enabled = true };
            var serviceTypes = await mediator.Send(command, cancellationToken);
            return Ok(ResponseGetServiceTypes.Build(serviceTypes));
        }
    }
