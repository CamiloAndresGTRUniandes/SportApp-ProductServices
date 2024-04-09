namespace SportApp.ProductsServices.Domain.Allergies ;
using ProductService;

    public class ProductServiceNutritionalAllergies
    {
        public ProductService ProductService { get; set; }
        public NutritionalAllergy NutritionalAllergy { get; set; }

        public static ProductServiceNutritionalAllergies Build(ProductService productService, NutritionalAllergy nutritionalAllergy)
        {
            var productServiceAllergies = productService.ProductServiceAllergies.FirstOrDefault(pa => pa.NutritionalAllergy == nutritionalAllergy);
            //productServiceAllergies ??= nutritionalAllergy.ProductServiceAllergies.FirstOrDefault(pa => pa.ProductService == productService);

            if (productServiceAllergies != null)
            {
                return productServiceAllergies;
            }
            return new ProductServiceNutritionalAllergies { ProductService = productService, NutritionalAllergy = nutritionalAllergy };
        }
    }
