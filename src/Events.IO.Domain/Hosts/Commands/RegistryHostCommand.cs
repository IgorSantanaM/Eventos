using Events.IO.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.IO.Domain.Hosts.Commands
{
    public class RegistryHostCommand : Command
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }

        public RegistryHostCommand(Guid id, string name, string cpf, string email)
        {
            Id = id;
            Name = name;
            CPF = cpf;
            Email = email;

        }
    }
}
