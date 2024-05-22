namespace SportApp.ProductsServices.Application.Subscription.Exceptions ;
using Domain.Common.Exceptions;

    public class DowngradeSubscriptionConflictException(Guid id) : BusinessException($"No es posible elegir una supscrición menor a la activa: ${id}")
    {
    }
