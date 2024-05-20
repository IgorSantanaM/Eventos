using Events.IO.Domain.Core.Events;

namespace Events.IO.Domain.Core.Commands
{
    public class Command : Message
    {
        public DateTime TimeStamp { get; private set; }

        public Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
