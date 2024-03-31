namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Commands;

    public interface ICreatePlan
    {
        ValueTask<Plan> ExecuteAsync(CreatePlanCommand request);
    }
