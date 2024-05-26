using Events.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.IO.Domain.Hosts.Events
{
    public class HostEventHandler : IHandler<HostRegistredEvent>
    {
        public void Handle(HostRegistredEvent message)
        {
            
        }
    }
}
