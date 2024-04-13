namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Interfaces;

    public class CreateCategoryCommandHandler(
        [NotNull] ICreateCategory createCategory) :
            IDomainRequestHandler<CreateCategoryCommand, Category>
    {
        public async Task<Category> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await createCategory.ExecuteAsync(request);
            return category;
        }
    }
