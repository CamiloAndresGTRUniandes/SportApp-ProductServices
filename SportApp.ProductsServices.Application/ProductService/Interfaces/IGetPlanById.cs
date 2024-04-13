namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Queries;

    public interface IGetPlanById
    {
        ValueTask<Plan?> ExecuteAsync(GetPlanByIdQuery request);
    }
