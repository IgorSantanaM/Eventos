namespace Events.IO.Domain.DEvents.Events
{
    public class EventUpdatedEvent : BaseEventEvent
    {
        public EventUpdatedEvent(Guid id, string name, string shortDesc, string longDesc, DateTime beginDate, DateTime endDate, bool free, decimal price, bool online, string companyName)
        {
			id = id;
			Name = name;
			ShortDescription = shortDesc;
			LongDescription = longDesc;
			BeginDate = beginDate;
			EndDate = endDate;
			Free = free;
			Price = price;
			Online = online;
			CompanyName = companyName;

			AggregateId = id;
        }
    }
}
