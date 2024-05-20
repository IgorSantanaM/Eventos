namespace Events.IO.Domain.DEvents.Events
{
    public class EventRegistradeEvent : BaseEventEvent
    {
        public EventRegistradeEvent(Guid id, string name, DateTime beginDate, DateTime endDate, bool free, decimal value, bool online, string companyName)
        {
			Name = name;
			BeginDate = beginDate;
			EndDate = endDate;
			Free = free;
			Value = value;
			Online = online;
			CompanyName = companyName;

			AggregateId = id;
        }
    }
}
