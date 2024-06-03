using Dapper;
using Events.IO.Domain.Core.Events;
using Events.IO.Domain.DEvents;
using Events.IO.Domain.DEvents.Repository;
using Events.IO.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var sql = @"SELECT * FROM Events E 
                        WHERE E.Deleted = 0 
                        ORDER BY E.EndDate DESC";

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

        public Address GetAddressById(Guid id)
        {
            var sql = @"SELECT * FROM Addresses A 
                        WHERE A.Id = @uid";

            IEnumerable<Address> addresses = Db.Database.GetDbConnection().Query<Address>(sql, new { uid = id });

            return addresses.SingleOrDefault();
        }

        public IEnumerable<DEvent> GetEventByHost(Guid hostId)
        {
            var sql = @"SELECT * FROM Events E 
                        WHERE E.Deleted = 0 
                        AND E.HostId = @hostId 
                        ORDER BY E.EndDate DESC";

            return Db.Database.GetDbConnection().Query<DEvent>(sql, new { hostId });
        }

        public override DEvent GetById(Guid id)
        {
            var sql = @"SELECT * FROM Events E 
                        LEFT JOIN Addresses A ON E.Id = A.EventId 
                        WHERE E.Id = @uid";

            var eventDictionary = new Dictionary<Guid, DEvent>();

            var devents = Db.Database.GetDbConnection().Query<DEvent, Address, DEvent>(
                sql,
                (devent, address) =>
                {
                    if (!eventDictionary.TryGetValue(devent.Id, out var eventEntry))
                    {
                        eventEntry = devent;
                        eventDictionary.Add(eventEntry.Id, eventEntry);
                    }

                    if (address != null)
                    {
                        eventEntry.AssignAddress(address);
                    }

                    return eventEntry;
                },
                new { uid = id },
                splitOn: "Id"
            );

            return devents.FirstOrDefault();
        }
        public override void Remove(Guid id)
        {
            var devent = GetById(id);
            devent.DeleteEvent();
            Update(devent);
        }
    }
}
