namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Queries;

    public interface IGetAllPlans
    {
        ValueTask<ICollection<Plan>> ExecuteAsync(GetAllPlansQuery request);
    }
