using Events.IO.Domain.Interface;

namespace Events.IO.Domain.DEvents.Repository
{
    public interface IEventRepository : IRepository<DEvent>
    {
        IEnumerable<DEvent> GetEventByHost(Guid hostId);
        Address GetAddressById(Guid id);
        void AddAddress(Address address);
        void UpdateAddress(Address address);
    }
}
