namespace SportApp.ProductsServices.Api.Middleware ;

using System.Net;
using Application.ProductService.Exceptions;
using Domain.Common.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Net.Http.Headers;

    /// <summary>
    /// Exception middleware extensions
    /// </summary>
    public static class ExceptionMiddlewareExtensions
    {
        /// <summary>
        /// Add exception middleware
        /// </summary>
        /// <param name="builder"></param>
        public static void UseExceptionMiddleware(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ExceptionMiddleware>();
        }

        /// <summary>
        /// Custom MVC BadRequest errors
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static CustomErrorResponse ConstructErrorMessages(this ActionContext context)
        {
            var invalidModels = context.ModelState
                .Where(v => v.Value.ValidationState == ModelValidationState.Invalid).ToList();

            var allErrors = string.Join(" ", invalidModels
                .Select(m => $"{m.Key}: {string.Join(", ", m.Value.Errors.Select(e => e.ErrorMessage).ToList())}"));

            var errorString = $"One or more validation errors occurred. {allErrors}";

            return new CustomErrorResponse(LoggingEvents.BadRequest, errorString);
        }

        /// <summary>
        /// Format error with code and message
        /// </summary>
        /// <param name="response"></param>
        /// <param name="businessException"></param>
        /// <returns></returns>
        public static Task<EventId> SportAppErrorResponseAsync(this HttpResponse response,
            Exception businessException)
        {
            var (httpStatusCode, eventId) = GetResponseCode(businessException.GetType().Name);
            var message = $"{{\"code\": {eventId},\"message\":\"{businessException.Message}\"}}";
            response.Clear();
            response.StatusCode = (int)httpStatusCode;
            response.ContentType = "application/json";
            response.GetTypedHeaders().CacheControl =
                new CacheControlHeaderValue { NoStore = true, NoCache = true };
            response.WriteAsync(message);

            return Task.FromResult(eventId);
        }

        private static (HttpStatusCode, EventId) GetResponseCode(string exception)
        {
            return exception switch
            {
                //NotFound

                //BadRequest
                nameof(NameMaxLengthException) => (HttpStatusCode.BadRequest, LoggingEvents.NameMaxLengthException),
                nameof(DescriptionMaxLengthException) => (HttpStatusCode.BadRequest, LoggingEvents.DescriptionMaxLengthException),
                nameof(InvalidDisplayNameException) => (HttpStatusCode.BadRequest, LoggingEvents.InvalidDisplayName),

                //Conflict
                nameof(PlanNotFoundConflictException) => (HttpStatusCode.Conflict, LoggingEvents.PlanNotFoundException),
                nameof(CategoryNotFoundConflictException) => (HttpStatusCode.Conflict, LoggingEvents.CategoryNotFoundException),
                nameof(CategoryAlreadyExistConflictException) => (HttpStatusCode.Conflict, LoggingEvents.CategoryAlreadyExistException),
                nameof(TypeOfNutritionAlreadyExistConflictException) => (HttpStatusCode.Conflict, LoggingEvents.TypeOfNutritionAlreadyExistException),
                nameof(TypeOfNutritionNotFoundConflictException) => (HttpStatusCode.Conflict, LoggingEvents.TypeOfNutritionNotFoundException),
                nameof(GeographicInfoNotFoundConflictException) => (HttpStatusCode.Conflict, LoggingEvents.GeographicInfoNotFoundException),
                nameof(ServiceTypeNotFoundConflictException) => (HttpStatusCode.Conflict, LoggingEvents.ServiceTypeNotFoundException),

                //Service Unavailable

                //Internal Server Error

                //Forbidden

                //Default
                _ => (HttpStatusCode.InternalServerError, LoggingEvents.Unknown)
                };
        }
    }
