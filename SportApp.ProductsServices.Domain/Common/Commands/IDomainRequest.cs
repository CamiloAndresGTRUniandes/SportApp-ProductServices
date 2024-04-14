namespace SportApp.ProductsServices.Domain.Common.Commands ;

using MediatR;

    public interface IDomainRequest<out TResponse> : IRequest<TResponse>
    {
    }
