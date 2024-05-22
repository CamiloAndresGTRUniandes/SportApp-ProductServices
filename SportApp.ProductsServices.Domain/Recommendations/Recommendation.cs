namespace SportApp.ProductsServices.Domain.Recommendations ;
using Common;
using ProductService;

    public class Recommendation : BaseDomainModel
    {
        protected Recommendation()
        {
        }

        private Recommendation(Guid id, Guid user, ProductService productService)
        {
            Id = id;
            User = user;
            ProductService = productService;
            CreatedBy = user;
            UpdatedBy = user;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Enabled = true;
        }

        public Guid User { get; set; }
        public ProductService ProductService { get; set; }

        public static Recommendation Build(Guid id, Guid user, ProductService productService)
        {
            var recommendation = new Recommendation(id, user, productService);
            recommendation.SetAdded();
            return recommendation;
        }
    }
