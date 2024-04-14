namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Allergies;
using Domain.Common.Commands;
using Domain.ProductService.Queries;
using Interfaces;

    public class GetAllNutritionalAllergiesQueryHandler([NotNull] IGetAllNutritionalAllergies getAllNutritionalAllergies) :
        IDomainRequestHandler<GetAllNutritionalAllergiesQuery, ICollection<NutritionalAllergy>>
    {
        public async Task<ICollection<NutritionalAllergy>> Handle(GetAllNutritionalAllergiesQuery request, CancellationToken cancellationToken)
        {
            var nutritionalAllergies = await getAllNutritionalAllergies.ExecuteAsync(request);
            return nutritionalAllergies;
        }
    }
