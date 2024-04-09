namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Interfaces;

    public class GetProductServiceQueryHandler([NotNull] IGetProductService getProductService) :
        IDomainRequestHandler<GetProductServiceQuery, ProductService>
    {
        public async Task<ProductService> Handle(GetProductServiceQuery request, CancellationToken cancellationToken)
        {
            return await getProductService.ExecuteAsync(request);
        }
    }
