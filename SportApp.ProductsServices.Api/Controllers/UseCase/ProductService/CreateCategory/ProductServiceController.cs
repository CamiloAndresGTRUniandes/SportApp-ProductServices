namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateCategory
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
        [Route("category")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateCategoryAsync([FromBody] RequestCreateCategory request, CancellationToken cancellationToken)
        {
            var command = new CreateCategoryCommand
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                User = request.User
            };
            await mediator.Send(command, cancellationToken);
            return NoContent();
        }
    }
}
