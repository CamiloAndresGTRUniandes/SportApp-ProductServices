namespace SportApp.ProductsServices.Application.Goal.Handlers ;
using System.Diagnostics.CodeAnalysis;
using Domain.Common.Commands;
using Domain.Goals;
using Domain.Goals.Commands;
using Interfaces;

    public class CreateGoalCommandHandler([NotNull] ICreateGoal createGoal) : IDomainRequestHandler<CreateGoalCommand, Goal>
    {
        public async Task<Goal> Handle(CreateGoalCommand request, CancellationToken cancellationToken)
        {
            return await createGoal.ExecuteAsync(request);
        }
    }
