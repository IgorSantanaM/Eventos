using Events.IO.Domain.Core.Bus;
using Events.IO.Domain.Core.Commands;
using Events.IO.Domain.Core.Events;
using Events.IO.Domain.Core.Notifications;

namespace Events.IO.Infra.CrossCutting.Bus
{
    public sealed class InMemoryBus : IBus
    {
        public static Func<IServiceProvider> ContainerAccessor { get; set; }
        private static IServiceProvider Container => ContainerAccessor();

        public void RaiseEvent<T>(T theEvent) where T : Event
        {
            Publish(theEvent);
        }

        public void SendCommand<T>(T theCommand) where T : Command
        {
<<<<<<< HEAD
            Publish(theCommand); 
        }   
        private static void Publish<T>(T message) where T : Message
        {
            if (Container == null) return;
=======
            Publish(theCommand);
        }   
        private static void Publish<T>(T message) where T : Message
        {
            if (Container is null) return;
>>>>>>> TesteApi

            var obj = Container.GetService(message.MessageType.Equals("DomainNotification")
                ? typeof(IDomainNotificationHandler<T>)
                : typeof(IHandler<T>));

            ((IHandler<T>)obj).Handle(message);
        }
    }
}
