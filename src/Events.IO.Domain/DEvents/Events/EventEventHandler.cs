using Events.IO.Domain.Core.Events;

namespace Events.IO.Domain.DEvents.Events
{
    public class EventEventHandler :
        IHandler<EventRegistradeEvent>,
        IHandler<EventUpdatedEvent>,
        IHandler<EventDeletedEvent>
    {
        public void Handle(EventUpdatedEvent message)
        {
            //Email
        }

        public void Handle(EventRegistradeEvent message)
        {
            //Email

        }

        public void Handle(EventDeletedEvent message)
        {
            //Email

        }
    }
}
