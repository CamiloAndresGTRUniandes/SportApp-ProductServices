namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.GetProductService ;
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
        [Route("getFilteredList")]
        [ProducesResponseType(typeof(List<ResponseGetProductService>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProductServicesAsync([FromBody] RequestGetProductService request,
            CancellationToken cancellationToken)
        {
            var command = new GetProductServiceCommand
            {
                Id = request.Id,
                User = request.User,
                ServiceTypes = request.ServiceTypes,
                StartDateTime = request.StartDateTime,
                EndDateTime = request.EndDateTime,
                Activities = request.Activities,
                Goals = request.Goals,
                TypesOfNutrition = request.TypesOfNutrition,
                Plans = request.Plans,
                GeographicInfoIds = request.GeographicInfoIds,
                Allergies = request.Allergies
            };
            var productServices = await mediator.Send(command, cancellationToken);
            return Ok(ResponseGetProductService.Build(productServices));
        }
    }
