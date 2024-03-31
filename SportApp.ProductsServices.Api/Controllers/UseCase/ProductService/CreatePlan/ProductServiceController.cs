namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreatePlan
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
        [Route("plan")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreatePlanAsync([FromBody] RequestCreatePlan request, CancellationToken cancellationToken)
        {
            var command = new CreatePlanCommand
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                User = request.User,
                Price = request.Price
            };
            await mediator.Send(command, cancellationToken);
            return NoContent();
        }
    }
}
