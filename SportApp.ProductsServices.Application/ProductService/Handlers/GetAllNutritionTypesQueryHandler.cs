namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Queries;
using Interfaces;

    public class GetAllNutritionTypesQueryHandler([NotNull] IGetAllTypeOfNutrition getAllTypeOfNutrition) :
        IDomainRequestHandler<GetAllNutritionTypesQuery, ICollection<TypeOfNutrition>>
    {
        public async Task<ICollection<TypeOfNutrition>> Handle(GetAllNutritionTypesQuery request, CancellationToken cancellationToken)
        {
            return await getAllTypeOfNutrition.ExecuteAsync(request);
        }
    }
