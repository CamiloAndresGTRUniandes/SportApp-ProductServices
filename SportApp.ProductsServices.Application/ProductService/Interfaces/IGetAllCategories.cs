namespace SportApp.ProductsServices.Application.ProductService.Interfaces ;
using Domain.ProductService;
using Domain.ProductService.Queries;

    public interface IGetAllCategories
    {
        ValueTask<ICollection<Category>> ExecuteAsync(GetAllCategoriesQuery request);
    }
