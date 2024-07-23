using Events.IO.Domain.Hosts;
using Events.IO.Domain.Hosts.Repository;
using Events.IO.Infra.Data.Context;
using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.IO.Infra.Data.Repository
{
    public class HostRepository : Repository<Host>, IHostRepository
    {
        public HostRepository(EventsContext context) : base(context)
        {
        }
    }
}
