using Events.IO.Domain.Core.Events;

namespace Events.IO.Domain.DEvents.Events
{
    public abstract class BaseEventEvent : Event
    {
		public Guid Id { get; set; }
		public string Name { get; protected set; }
		public string ShortDescription { get; protected set; }
		public string LongDescription { get; protected set; }
		public DateTime BeginDate { get; protected set; }
		public DateTime EndDate { get; protected set; }
		public bool Free { get; protected set; }
		public decimal Price { get; protected set; }
		public bool Online { get; protected set; }
		public string CompanyName { get; protected set; }
	}
}
