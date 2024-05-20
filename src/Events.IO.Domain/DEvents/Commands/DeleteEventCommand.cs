
namespace Events.IO.Domain.DEvents.Commands
{
    public class DeleteEventCommand : BaseEventCommand
    {
        public DeleteEventCommand(Guid id)
        {
            Id = id;
            AggregateId = Id;
        }
    }
}
