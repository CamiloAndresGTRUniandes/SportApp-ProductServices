namespace SportApp.ProductsServices.Domain.ProductService.Events ;
using Common.Constants;
using Common.Events;

    public class ProductServiceRecommendationCommand : Event
    {
        public ProductServiceRecommendationCommand()
        {
            Queue = Queues.ProductServiceCommands;
        }

        public Guid ProductId { get; set; }
    }
