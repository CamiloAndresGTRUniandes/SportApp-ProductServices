namespace SportApp.ProductsServices.Api.Middleware ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Exceptions;

    public class ExceptionMiddleware
    {
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly RequestDelegate _next;

        public ExceptionMiddleware([NotNull] ILogger<ExceptionMiddleware> logger, [NotNull] RequestDelegate next)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            if (httpContext == null)
            {
                return;
            }

            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                if (ex is BusinessException)
                {
                    var eventId = await httpContext.Response.SportAppErrorResponseAsync(ex);
                    _logger.LogWarning(eventId, "{error}", ex.Message);
                }
                else
                {
                    _logger.LogWarning(LoggingEvents.Unknown, "Exception not controlled or logged");
                    _logger.LogError(ex, "{error}", ex.Message);
                    await httpContext.Response.SportAppErrorResponseAsync(ex);
                }
            }
        }
    }
