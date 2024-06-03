using Events.IO.Domain.Core.Events;

namespace Events.IO.Domain.DEvents.Events
{
    public class EventEventHandler :
        IHandler<EventRegistredEvent>,
        IHandler<EventUpdatedEvent>,
        IHandler<EventDeletedEvent>,
        IHandler<AddressEventRegistredEvent>,
        IHandler<AddressEventUpdatedEvent>
    {
        public void Handle(EventUpdatedEvent message)
        {
            //Email
        }

        public void Handle(EventRegistredEvent message)
        {
            //Email

        }

        public void Handle(EventDeletedEvent message)
        {
            //Email

        }
        public void Handle(AddressEventRegistredEvent message)
        {
            //Email

        }public void Handle(AddressEventUpdatedEvent message)
        {
            //Email

        }
    }
}
