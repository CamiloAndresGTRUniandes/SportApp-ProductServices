namespace SportApp.ProductsServices.Domain.Goals ;
using ProductService;

    public class ProductServiceGoals
    {
        public ProductService ProductService { get; set; }
        public Goal Goal { get; set; }

        public static ProductServiceGoals Build(ProductService productService, Goal goal)
        {
            var productServiceGoal = productService.ProductServiceGoals.FirstOrDefault(pg => pg.Goal == goal);
            productServiceGoal ??= goal.ProductServiceGoals.FirstOrDefault(pg => pg.ProductService == productService);
            if (productServiceGoal != null)
            {
                return productServiceGoal;
            }
            return new ProductServiceGoals { ProductService = productService, Goal = goal };
        }
    }
