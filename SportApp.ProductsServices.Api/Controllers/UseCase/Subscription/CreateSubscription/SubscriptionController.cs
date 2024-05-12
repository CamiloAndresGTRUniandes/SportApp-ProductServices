namespace SportApp.ProductsServices.Api.Controllers.UseCase.Subscription.CreateSubscription ;

using System.Diagnostics.CodeAnalysis;
using Domain.Subscription;
using Domain.Subscription.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Middleware;

    [Route("api/v1/subscription")]
    [ApiController]
    public class SubscriptionController(
        [NotNull] IMediator mediator
        ) : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateSubscriptionAsync([FromBody] RequestCreateSubscription request, CancellationToken cancellationToken)
        {
            var command = new CreateSubscriptionCommand
            {
                Id = Guid.NewGuid(),
                User = request.User,
                StartDate = request.StartDate,
                EndDate = request.StartDate.AddDays(30),
                PlanId = request.PlanId
            };
            await mediator.Send(command, cancellationToken);
            return NoContent();
        }

        [HttpGet]
        [Route("{userId:guid}")]
        [ProducesResponseType(typeof(SubscriptionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetSubscriptionByUserIdAsync(Guid userId,
            CancellationToken cancellationToken)
        {
            var command = new GetSubscriptionQuery
            {
                UserId = userId
            };
            var subscription = await mediator.Send(command, cancellationToken);
            return Ok(SubscriptionResponse.Build(subscription));
        }
    }
