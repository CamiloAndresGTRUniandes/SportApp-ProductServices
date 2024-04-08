namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Interfaces;

    public class GetAllCategoriesQueryHandler([NotNull] IGetAllCategories getAllCategories) :
        IDomainRequestHandler<GetAllCategoriesQuery, ICollection<Category>>
    {
        public async Task<ICollection<Category>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await getAllCategories.ExecuteAsync(request);
        }
    }
