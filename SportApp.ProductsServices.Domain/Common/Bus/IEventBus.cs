namespace SportApp.ProductsServices.Domain.Common.Bus ;
using Commands;
using Events;

    public interface IEventBus
    {
        Task<bool> PublishAsync<T>(T even) where T : Event;
        Task SendCommand<T>(T command) where T : Command;

        void Subscribe<T, TH>(string queue)
            where T : Event
            where TH : IEventHandler<T>;
    }
