namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateServiceType
{
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
        [Route("serviceType")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateCategoryAsync([FromBody] RequestCreateServiceType request, CancellationToken cancellationToken)
        {
            var command = new CreateServiceTypeCommand
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                User = request.User,
                Picture = request.Picture,
                CategoryId = request.CategoryId
            };
            await mediator.Send(command, cancellationToken);
            return NoContent();
        }
    }
}
