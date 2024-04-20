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
                Id = request.ProductId.HasValue && request.ProductId != Guid.Empty ? request.ProductId.Value : Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                Picture = request.Picture,
                CountryId = request.CountryId,
                CityId = request.CityId,
                StateId = request.StateId,
                PlanId = request.PlanId,
                Price = request.Price ?? 0,
                ServiceTypeId = request.ServiceTypeId,
                TypeOfNutritionId =
                    request.TypeOfNutritionId.HasValue && request.TypeOfNutritionId != Guid.Empty ? request.TypeOfNutritionId.Value : null,
                SportLevel = Enumeration.FromValue<SportLevel>(request.SportLevel),
                User = request.User,
                Activities = request.Activities,
                Goals = request.Goals,
                Allergies = request.NutritionalAllergies,
                StartDateTime = request.StartDateTime,
                EndDateTime = request.EndDateTime,
                NutritionalPlan = request.NutritionalPlan
            };
            await mediator.Send(command, cancellationToken);
            return NoContent();
        }
    }
