namespace SportApp.ProductsServices.Domain.Activities ;
using ProductService;

    public class ProductServiceActivities
    {
        public ProductService ProductService { get; set; }
        public Activity Activity { get; set; }

        public static ProductServiceActivities Build(ProductService productService, Activity activity)
        {
            var productServiceActivities = productService.ProductServiceActivities.FirstOrDefault(pa => pa.Activity == activity);
            productServiceActivities ??= activity.ProductServiceActivities.FirstOrDefault(pa => pa.ProductService == productService);

            if (productServiceActivities != null)
            {
                return productServiceActivities;
            }
            return new ProductServiceActivities { ProductService = productService, Activity = activity };
        }
    }
