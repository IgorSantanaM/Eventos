using Events.IO.Domain.Core.Commands;

namespace Events.IO.Domain.DEvents.Commands
{
    public class BaseEventCommand : Command
    {
        public Guid Id { get; set; }
        public string Name { get; protected set; }
        public string ShortDescription { get; protected set; }
        public string LongDescription { get; protected set; }
        public DateTime BeginDate { get; protected set; }
        public DateTime EndDate { get; protected set; }
        public bool Free { get; protected set; }
        public decimal Value { get; protected set; }
        public bool Online { get; protected set; }
        public string CompanyName { get; protected set; }
        public Guid HostId { get; protected set; }
        public Address Address { get; protected set; }
        public Category Category{ get; protected set; }
    }
}
