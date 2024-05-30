using Dapper;
using Events.IO.Domain.Core.Events;
using Events.IO.Domain.DEvents;
using Events.IO.Domain.DEvents.Repository;
using Events.IO.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Events.IO.Infra.Data.Repository
{
    public class EventRepository : Repository<DEvent>, IEventRepository
    {
        private readonly EventsContext _context;
        public EventRepository(EventsContext context) : base(context)
        {
            _context = context;
        }
        public override IEnumerable<DEvent> GetAll()
        {
            var sql = "SELECT * FROM EVENTS E " +
                    "WHERE E.DELETED = 0 " +
                    "ORDER BY E.ENDDATE DESC";

            return Db.Database.GetDbConnection().Query<DEvent>(sql);
        }

        public void AddAddress(Address address)
        {
            Db.Addresses.Add(address);

        }

        public void UpdateAddress(Address address)
        {
            Db.Addresses.Update(address);
        }

        public  Address GetAddressById(Guid id)
        {
            var sql = @"SELECT * FROM Adresses A " +
                      "WHERE E.Id = @udi";

            IEnumerable<Address> addresses = Db.Database.GetDbConnection().Query<Address>(sql, new { uid = id });

            return addresses.SingleOrDefault();
        }

        public IEnumerable<DEvent> GetEventByHost(Guid hostId)
        {
            string sql = @"SELECT * FROM Events E " +
                      "WHERE E.DELETED = 0 " +
                      "AND E.HOST = @oid " +
                      "ORDER BY E.ENDDATE DESC";

            return Db.Database.GetDbConnection().Query<DEvent>(sql, new { oid = hostId });
        }
        public override DEvent GetById(Guid id)
        {
            string sql = @"SELECT * FROM Events E " +
                      "LEFT JOIN Address EN " +
                      "ON E.Id = EN.EventId " +
                      "WHERE E.Id = @uid";

            var devent = Db.Database.GetDbConnection().Query<DEvent, Address, DEvent>(sql,
            (e, en) =>
            {
                if(en != null)
                    e.AssignAddress(en);

                return e;
            }, new {uid = id });
                return devent.FirstOrDefault(); 
        }
    }
}
