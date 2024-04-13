﻿namespace SportApp.ProductsServices.Api.Controllers.UseCase.ProductService.CreateTypeOfNutrition ;
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
        [Route("typeOfNutrition")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(CustomErrorResponse), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateTypeOfNutritionAsync([FromBody] RequestCreateTypeOfNutrition request,
            CancellationToken cancellationToken)
        {
            var command = new CreateTypeOfNutritionCommand
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                User = request.User
            };
            await mediator.Send(command, cancellationToken);
            return NoContent();
        }
    }
