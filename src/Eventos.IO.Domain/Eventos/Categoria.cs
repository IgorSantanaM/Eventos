using Eventos.IO.Domain.Core.Models;

namespace Eventos.IO.Domain.Eventos
{
    public class Categoria : Entity<Categoria>
    {
        public Categoria(Guid id)
        {
            Id = id;
        }
        public string Nome { get; private set; }
        public virtual ICollection<Evento> Eventos { get;  set; }

        protected Categoria() { }
        public override bool EhValido()
        {
            return true;
        }
    }
}