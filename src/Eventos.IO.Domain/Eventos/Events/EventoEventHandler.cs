using Eventos.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.IO.Domain.Eventos.Events
{
    public class EventoEventHandler :
        IHandler<EventoRegistradoEvent>,
        IHandler<EventoAtualizadoEvent>,
        IHandler<EventoExcluidoEvent>
    {
        public void Handle(EventoAtualizadoEvent message)
        {
            //Email
        }

        public void Handle(EventoRegistradoEvent message)
        {
            //Email

        }

        public void Handle(EventoExcluidoEvent message)
        {
            //Email

        }
    }
}
