using Events.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.IO.Domain.Hosts.Events
{
    public class HostRegistredEvent : Event
    {
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }

        public HostRegistredEvent(Guid id, string name, string cpf, string email)
        {
            Id = id;
            Name = name;
            CPF = cpf;
            Email = email;

        }
    }
}
