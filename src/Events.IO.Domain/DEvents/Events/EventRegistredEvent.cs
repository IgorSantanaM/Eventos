namespace Events.IO.Domain.DEvents.Events
{
    public class EventRegistredEvent : BaseEventEvent
    {
        public EventRegistredEvent(Guid id, string name, DateTime beginDate, DateTime endDate, bool free, decimal price, bool online, string companyName)
        {
			Name = name;
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
