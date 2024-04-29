namespace SportApp.ProductsServices.Application.Subscription.Exceptions ;
using Domain.Common.Exceptions;

    public class ExistingSubscriptionConflictException(Guid id) : BusinessException($"Existe una suscripcion activa para el usuaio: ${id}")
    {
    }
