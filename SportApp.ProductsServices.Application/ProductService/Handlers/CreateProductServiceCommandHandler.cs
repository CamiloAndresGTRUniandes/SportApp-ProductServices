namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Interfaces;

    public class CreateProductServiceCommandHandler([NotNull] ICreateProductService createProductService) :
        IDomainRequestHandler<CreateProductServiceCommand, ProductService>
    {
        public async Task<ProductService> Handle(CreateProductServiceCommand request, CancellationToken cancellationToken)
        {
            var productService = await createProductService.ExecuteAsync(request);
            return productService;
        }
    }
