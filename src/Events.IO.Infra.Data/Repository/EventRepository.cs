using Events.IO.Domain.DEvents;
using Events.IO.Domain.DEvents.Repository;
using Events.IO.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Events.IO.Infra.Data.Repository
{
    public class EventRepository : Repository<DEvent>, IEventRepository
    {
        public EventRepository(EventsContext context) : base(context)
        {

        }

        public void AddAddress(Address address)
        {
            Db.Addresses.Add(address);

        }

        public void UpdateAddress(Address address)
        {
            Db.Addresses.Update(address);
        }

        public Address GetAddressById(Guid id)
        {
            return Db.Addresses.Find(id);
        }

        public IEnumerable<DEvent> GetEventByHost(Guid hostId)
        {
            return Db.DEvents.Where(e => e.HostId == hostId);
        }
        public DEvent GetById(Guid id)
        {
            return Db.DEvents.Include(e => e.Address).FirstOrDefault(e => e.Id == id); 
        }
    }
}
