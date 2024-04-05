namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateProductService ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common;
using Domain.Common.Enums;
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
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateProductServiceAsync([FromBody] RequestCreateProductService request,
            CancellationToken cancellationToken)
        {
            var command = new CreateProductServiceCommand
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                Picture = request.Picture,
                GeographicInfoId = request.GeographicInfoId,
                PlanId = request.PlanId,
                Price = request.Price ?? 0,
                ServiceTypeId = request.ServiceTypeId,
                TypeOfNutritionId = request.TypeOfNutritionId,
                SportLevel = Enumeration.ToEnumerator(request.SportLevel, SportLevel.Basic),
                User = request.User,
                Activities = request.Activities,
                Goals = request.Goals,
                Allergies = request.Allergies
            };
            await mediator.Send(command, cancellationToken);
            return NoContent();
        }
    }
