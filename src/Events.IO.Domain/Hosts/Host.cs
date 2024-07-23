using Events.IO.Domain.Core.Models;
using Events.IO.Domain.DEvents;
namespace Events.IO.Domain.Hosts
{
    public class Host : Entity<Host>
    {
        public string Name { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }

        public Host(Guid id, string name, string cpf, string email)
        {
            Id = id;
            Name = name;
            CPF = cpf;
            Email = email;

        }
        protected Host() { }

        public virtual ICollection<DEvent> DEvents{ get; set; }
        public override bool IsValidate()
        {
            return true;
        }
    }
}