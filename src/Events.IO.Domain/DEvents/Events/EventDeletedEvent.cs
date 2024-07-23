namespace Events.IO.Domain.DEvents.Events
{
    public class EventDeletedEvent : BaseEventEvent
    {
        public EventDeletedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
    }
}
