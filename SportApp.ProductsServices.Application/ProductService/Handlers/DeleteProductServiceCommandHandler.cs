namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Interfaces;

    public class DeleteProductServiceCommandHandler([NotNull] IDeleteProductService deleteProductService) :
        IDomainRequestHandler<DeleteProductServiceCommand, ProductService>
    {
        public async Task<ProductService> Handle(DeleteProductServiceCommand request, CancellationToken cancellationToken)
        {
            var productService = await deleteProductService.ExecuteAsync(request);
            return productService;
        }
    }
