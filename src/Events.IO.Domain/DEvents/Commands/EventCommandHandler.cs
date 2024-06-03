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
        IHandler<UpdateEventCommand>,
        IHandler<IncludeAddressEventCommand>,
        IHandler<UpdateAddressEventCommand>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IBus _bus;
        private readonly IUser _user;
        public EventCommandHandler(IEventRepository eventRepository, IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notifications, IUser user) : base(uow, bus, notifications)
        {
            _eventRepository = eventRepository;
            _bus = bus;
            _user = user;
        }
        public void Handle(RegistryEventCommand message)
        { 
            var address = new Address(message.Address.Id, message.Address.PublicPlace, message.Address.Number, message.Address.Complement, message.Address.Neighborhood, message.Address.ZipCode, message.Address.City, message.Address.State, message.Address.EventId.Value); 
        
            var devent = DEvent.EventFactory.NewCompletedEvent(
                message.Id,
                message.Name,
                message.ShortDescription,
                message.LongDescription,
                message.BeginDate,
                message.EndDate,
                message.Free,
                message.Price,
                message.Online,
                message.CompanyName,
                message.HostId,
                address,
                message.CategoryId);

            if (!ValidEvent(devent)) return;

            _eventRepository.Add(devent);


            if (Commit())
            {
                Console.WriteLine("Event registred");
                _bus.RaiseEvent(new EventRegistredEvent(devent.Id, devent.Name, devent.BeginDate, devent.EndDate, devent.Free, devent.Price, devent.Online, devent.CompanyName));
            }
        }
        public void Handle(UpdateEventCommand message)
        {
            var actualEvent = _eventRepository.GetById(message.Id);
            if (!ExistenceEvent(message.Id, message.MessageType)) return;
            if(actualEvent.HostId != _user.GetUserID())
            {
                _bus.RaiseEvent(new DomainNotification(message.MessageType, "Event is not owned by the host"));
                return;
            }

            var devent = DEvent.EventFactory.NewCompletedEvent(message.Id, message.Name, message.ShortDescription, message.LongDescription, message.BeginDate, message.EndDate, message.Free, message.Price, message.Online, message.CompanyName, message.HostId, actualEvent.Address, message.CategoryId);

            if(!devent.Online && devent.Address == null)
            {
                _bus.RaiseEvent(new DomainNotification(message.MessageType, "You cannot update an event without the address."));
                return;
            }
            if (!ValidEvent(devent)) return;

            _eventRepository.Update(devent);

            if (Commit())
            {
                _bus.RaiseEvent(new EventUpdatedEvent(devent.Id, devent.Name, devent.ShortDescription, devent.LongDescription, devent.BeginDate, devent.EndDate, devent.Free, devent.Price, devent.Online, devent.CompanyName));
            }
        }
        public void Handle(DeleteEventCommand message)
        {
            if (!ExistenceEvent(message.Id, message.MessageType)) return;
            var actualEvent = _eventRepository.GetById(message.Id);

            if (actualEvent.HostId != _user.GetUserID())
            {
                _bus.RaiseEvent(new DomainNotification(message.MessageType, "Event is not owned by the host"));
                return;
            }
            actualEvent.DeleteEvent();

            _eventRepository.Update(actualEvent);

            if (Commit())
            {
                _bus.RaiseEvent(new EventDeletedEvent(message.Id));
            }
        }
        private bool ValidEvent(DEvent evento)
        {
            if (evento.IsValidate()) return true;

            NotifyErrorValidations(evento.ValidationResult);

            return false;
        }
        private bool ExistenceEvent(Guid id, string messageType)
        {
            var devent = _eventRepository.GetById(id);

            if (devent != null) return true;

            _bus.RaiseEvent(new DomainNotification(messageType, "Event not found"));
            return false;
        }

        public void Handle(IncludeAddressEventCommand message)
        {
            var address = new Address(message.Id, message.PublicPlace, message.Number, message.Complement, message.Neighborhood, message.ZipCode, message.City, message.State, message.EventId.Value);
            if(!address.IsValidate())
            {
                NotifyErrorValidations(address.ValidationResult);
                return;
            }
            _eventRepository.AddAddress(address);

            if (Commit())
            {
                _bus.RaiseEvent(new AddressEventRegistredEvent(address.Id, address.PublicPlace, address.Number, address.Complement, address.Neighborhood, address.ZipCode, address.ZipCode, address.State, address.EventId.Value));
            }
        }

        public void Handle(UpdateAddressEventCommand message)
        {
            var address = new Address(message.Id, message.PublicPlace, message.Number, message.Complement, message.Neighborhood, message.ZipCode, message.City, message.State, message.EventId.Value);
            if (!address.IsValidate())
            {
                NotifyErrorValidations(address.ValidationResult);
                return;
            }
            _eventRepository.AddAddress(address);

            if (Commit())
            {
                _bus.RaiseEvent(new AddressEventUpdatedEvent(address.Id, address.PublicPlace, address.Number, address.Complement, address.Neighborhood, address.ZipCode, address.ZipCode, address.State, address.EventId.Value));

            }
        }
    }
}
