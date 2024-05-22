using Events.IO.Domain.CommandHandlers;
using Events.IO.Domain.Core.Bus;
using Events.IO.Domain.Core.Events;
using Events.IO.Domain.Core.Notifications;
using Events.IO.Domain.DEvents.Events;
using Events.IO.Domain.DEvents.Repository;
using Events.IO.Domain.Interface;

namespace Events.IO.Domain.DEvents.Commands
{
    public class EventCommandHandler : CommandHandler,
        IHandler<RegistryEventCommand>,
        IHandler<DeleteEventCommand>,
        IHandler<UpdateEventCommand>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IBus _bus;
        public EventCommandHandler(IEventRepository eventRepository, IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            _eventRepository = eventRepository;
            _bus = bus;
        }
        public void Handle(RegistryEventCommand message)
        {
            var devent = DEvent.EventFactory.NewCompletedEvent(
                message.Id,
                message.Name,
                message.ShortDescription,
                message.LongDescription,
                message.BeginDate,
                message.EndDate,
                message.Free,
                message.Value,
                message.Online,
                message.CompanyName,
                message.HostId,
                message.Address,
                message.Category.Id);

            if (!ValidEvent(devent)) return;

            _eventRepository.Add(devent);


            if (Commit())
            {
                Console.WriteLine("Event registred");
                _bus.RaiseEvent(new EventRegistradeEvent(devent.Id, devent.Name, devent.BeginDate, devent.EndDate, devent.Free, devent.Value, devent.Online, devent.CompanyName));
            }
        }
        public void Handle(UpdateEventCommand message)
        {
            var eventAtual = _eventRepository.GetByID(message.Id);
            if (!EventoExistente(message.Id, message.MessageType)) return;
            var evento = DEvent.EventFactory.NewCompletedEvent(message.Id, message.Name, message.ShortDescription, message.LongDescription, message.BeginDate, message.EndDate, message.Free, message.Value, message.Online, message.CompanyName, message.HostId, message.Address, message.Category.Id);

            if (!ValidEvent(evento)) return;

            _eventRepository.Update(evento);

            if (Commit())
            {
                _bus.RaiseEvent(new EventUpdatedEvent(evento.Id, evento.Name, evento.ShortDescription, evento.LongDescription, evento.BeginDate, evento.EndDate, evento.Free, evento.Value, evento.Online, evento.CompanyName));
            }
        }
        public void Handle(DeleteEventCommand message)
        {
            if (!EventoExistente(message.Id, message.MessageType)) return;

            _eventRepository.Remove(message.Id);

            if (Commit())
            {
                _bus.RaiseEvent(new EventDeletedEvent(message.Id));
            }
        }
        private bool ValidEvent(DEvent evento)
        {
            if (evento.IsValidate()) return true;

            NotificarValidacoesErro(evento.ValidationResult);

            return false;
        }
        private bool EventoExistente(Guid id, string messageType)
        {
            var evento = _eventRepository.GetByID(id);

            if (evento != null) return true;

            _bus.RaiseEvent(new DomainNotification(messageType, "Evento nnao encontrado."));
            return false;
        }
    }
}
