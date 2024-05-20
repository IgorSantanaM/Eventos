namespace Events.IO.Domain.DEvents.Commands
{
    public class RegistryEventCommand : BaseEventCommand
    {
        public RegistryEventCommand(string name,
            DateTime beginDate,
            DateTime endDate,
            bool free,
            decimal value,
            bool online,
            string companyName,
            Guid hostId,
            Address address,
            Category category)
        {
            Name = name;
            BeginDate = beginDate;
            EndDate = endDate;
            Free = free;
            Value = value;
            Online = online;
            CompanyName = companyName;
            HostId = hostId;
            Address = address;
            Category = category;

        }
    }
}
