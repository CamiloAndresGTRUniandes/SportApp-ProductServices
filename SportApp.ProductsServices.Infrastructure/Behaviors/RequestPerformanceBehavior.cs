namespace SportApp.ProductsServices.Infrastructure.Behaviors ;

using System.Diagnostics;
using MediatR;
using Microsoft.Extensions.Logging;

    public class RequestPerformanceBehavior<TRequest, TResponse>(ILogger<TRequest> logger) : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly int _requestElapsedMs = 1000;
        private readonly Stopwatch _timer = new();

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            _timer.Start();

            var response = await next();

            _timer.Stop();

            if (_timer.ElapsedMilliseconds > _requestElapsedMs)
            {
                var name = typeof(TRequest).Name;

                logger.LogWarning("Long Running Request: {Name} ({ElapsedMilliseconds:N0} ms) {@Request}",
                    name, _timer.ElapsedMilliseconds, request);
            }

            return response;
        }
    }
