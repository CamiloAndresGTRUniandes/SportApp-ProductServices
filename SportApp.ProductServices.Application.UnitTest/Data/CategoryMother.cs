namespace SportApp.ProductServices.Application.UnitTest.Data ;
using ProductsServices.Domain.ProductService;

    public static class CategoryMother
    {
        public static Category Create(
            string id = "7300e12e-f3df-4a8b-9847-45f07362cee9",
            string name = "New Category Name",
            string description = "New Category Description",
            string user = "6ad77258-01bf-4d2b-b8ee-37e2099e0216")
        {
            return Category.Build(Guid.Parse(id), name, description, Guid.Parse(user));
        }
    }
