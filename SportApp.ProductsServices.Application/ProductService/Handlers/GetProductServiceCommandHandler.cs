namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Interfaces;

    public class GetProductServiceCommandHandler([NotNull] IGetProductServices getProductServices) :
        IDomainRequestHandler<GetProductServiceCommand, ICollection<ProductService>>
    {
        public async Task<ICollection<ProductService>> Handle(GetProductServiceCommand request, CancellationToken cancellationToken)
        {
            return await getProductServices.ExecuteAsync(request);
        }
    }
