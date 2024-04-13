namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Interfaces;

    public class CreateTypeOfNutritionCommandHandler(
        [NotNull] ICreateTypeOfNutrition createTypeOfNutrition) : IDomainRequestHandler<CreateTypeOfNutritionCommand, TypeOfNutrition>
    {
        public async Task<TypeOfNutrition> Handle(CreateTypeOfNutritionCommand request, CancellationToken cancellationToken)
        {
            return await createTypeOfNutrition.ExecuteAsync(request);
        }
    }
