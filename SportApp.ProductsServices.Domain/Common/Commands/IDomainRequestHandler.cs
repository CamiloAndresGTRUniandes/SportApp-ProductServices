namespace SportApp.ProductsServices.Domain.Common.Commands ;

using MediatR;

    public interface IDomainRequestHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
    }
