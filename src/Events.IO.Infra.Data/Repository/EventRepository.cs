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
        public EventRepository(EventsContext context) : base(context)
        {

        }
        public override IEnumerable<DEvent> GetAll()
        {
            var sql = "SELECT * FROM EVENTS E" +
                    "WHERE E.DELETED = 0" +
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
            var sql = @"SELECT * FROM Adresses A" +
                      "WHERE E.Id = @udi";

            var address = Db.Database.GetDbConnection().Query<Address>(sql, new { uid = id });

            return address.SingleOrDefault();
        }

        public IEnumerable<DEvent> GetEventByHost(Guid hostId)
        {
            var sql = @"SELECT * FROM Events E" +
                      "WHERE E.DELETED = 0" +
                      "AND E.HOST = @oid" +
                      "ORDER BY E.ENDDATE DESC";

            return Db.Database.GetDbConnection().Query<DEvent>(sql, new { oid = hostId });
        }
        public override DEvent GetById(Guid id)
        {
            var sql = @"SELECT * FROM Events E" +
                      "LEFT JOIN Address EN" +
                      "ON E.Id = EN.EventId" +
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
