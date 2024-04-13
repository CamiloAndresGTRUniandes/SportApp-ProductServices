namespace SportApp.ProductsServices.Application.ProductService.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.ProductService;
using Domain.ProductService.Commands;
using Interfaces;

    public class CreatePlanCommandHandler(
        [NotNull] ICreatePlan createPlan) :
            IDomainRequestHandler<CreatePlanCommand, Plan>
    {
        public async Task<Plan> Handle(CreatePlanCommand request, CancellationToken cancellationToken)
        {
            var plan = await createPlan.ExecuteAsync(request);
            return plan;
        }
    }
